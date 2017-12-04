package com.mserver;

import com.interceptor.AuthInterceptor;
import com.mserver.jaxrs.PhoneServer;
import com.mserver.service.IndexService;
import com.mserver.service.impl.IndexServiceImpl;
import org.apache.cxf.Bus;
import org.apache.cxf.bus.spring.SpringBus;
import org.apache.cxf.endpoint.Server;
import org.apache.cxf.jaxrs.JAXRSServerFactoryBean;
import org.apache.cxf.jaxrs.swagger.Swagger2Feature;
import org.apache.cxf.jaxws.EndpointImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

import javax.xml.ws.Endpoint;
import java.util.Arrays;


/**
 * Created by cyl on 2017/10/9.
 */
@Configuration
public class CXFconfig {

//    @Bean
//    public ServletRegistrationBean dispatcherServlet() {
//        return new ServletRegistrationBean(new CXFServlet(), "/soap/*");
//    }

    @Autowired
    private Bus bus;

    @Bean(name = Bus.DEFAULT_BUS_ID)
    public SpringBus springBus() {
        return new SpringBus();
    }

    @Bean
    public IndexServiceImpl index() {
        return new IndexServiceImpl();
    }

    /**
     * 这里使用的是jaxws包下的，通过创建项目选择的apache cxf 是jaxrs方式其中的EndpointImpl构造方法不同
     * 关于JAX-WS 与JAX-RS
     * 简要说一下 JAX-WS 和JAX-RS
     * JAX-WS全称是JavaTM API forXML-Based Web Services
     * JAX-RS :全称是  JavaTM API forRESTful Web Services
     * JAX-WS是面向消息的，每次请求的时候指定了请求的方法。
     * JAX-RS是面向资源的。后则将网络上的东西当做一种资源，每次请求都是对该资源进行操作，比如对资源的增删查改
     * 默认在http://localhost:9090/services/路径下
     * 当与jaxrs方式共存时，由于jaxrs是restful风格的可通过http访问，因此按照其地址解析将会覆盖jaxws的默认/services(一个服务列表)路径
     * 但jaxws下http://localhost:9090/services/**路径仍可用，但不能与jaxrs路径重名
     * @return
     */
    @Bean
    public Endpoint endpoint() {

        EndpointImpl endpoint = new EndpointImpl(springBus(),index());
        endpoint.publish("/index");
        endpoint.getInInterceptors().add(new AuthInterceptor());
        return endpoint;
    }

//    /**
//     * 手动配置，自动扫描application.yml
//     * jax-rs 方式实现的是restful风格的webserver，
//     * 默认在http://localhost:9090/services/路径下
//     * @return
//     */
//    @Bean
//    public Server rsServer() {
//        JAXRSServerFactoryBean endpoint = new JAXRSServerFactoryBean();
//        endpoint.setBus(bus);
//        endpoint.setAddress("/");
//        // Register 2 JAX-RS root resources supporting "/sayHello/{id}" and "/sayHello2/{id}" relative paths
//        endpoint.setServiceBeans(Arrays.<Object>asList(new PhoneServer()));
//        endpoint.setFeatures(Arrays.asList(new Swagger2Feature()));
//        return endpoint.create();
//    }
}
