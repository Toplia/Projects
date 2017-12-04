package com.mclient.cxf;

import com.mclient.axis.AXISClient;
import com.mclient.cxf.interceptor.AuthInterceptor;
import com.mserver.service.IndexService;
import org.apache.cxf.endpoint.Client;
import org.apache.cxf.jaxrs.client.ClientConfiguration;
import org.apache.cxf.jaxrs.client.WebClient;
import org.apache.cxf.jaxws.JaxWsProxyFactoryBean;
import org.apache.cxf.jaxws.endpoint.dynamic.JaxWsDynamicClientFactory;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;

import javax.ws.rs.core.Response;
import javax.xml.namespace.QName;
import java.net.URL;

/**
 * Created by cyl on 2017/10/11.
 */
@Controller
@RequestMapping(value = "/")
public class CXFClient {
    private static final Logger LOG = LoggerFactory.getLogger(AXISClient.class);

    /**
     * //方式一:通过JaxWsDynamicClientFactory方式 动态调用
     * @return
     * @throws Exception
     */
    @RequestMapping(value = "/cxf")
    @ResponseBody
    public String index() throws Exception {

        String endpoint = "http://localhost:9090/services/index?wsdl";
        //String endpoint = "http://localhost:9090/services/info";
        String namespace = "http://service.mserver.com/";
        //String operation = "index";
        String operation = "testObj";


        JaxWsDynamicClientFactory dcf = JaxWsDynamicClientFactory.newInstance();
        URL url = new URL(endpoint);
        Client client = dcf.createClient(url);

        //Client client = dcf.createClient(endpoint);
        client.getRequestContext().put("method","get");
        client.getOutInterceptors().add(new AuthInterceptor());

        QName opName = new QName(namespace,operation);
        Object[] param = {"testObj1","testObj2","testObj3"};
        Object[] objects = client.invoke(opName, param);

        if (objects != null && objects.length > 0) {
            LOG.debug("result_class:" + objects[0].getClass());
            LOG.debug("result_msg:" + objects[0].toString());
            return objects[0].toString();
        } else {
            LOG.debug("[1]getName result_null");
        }
        return "result_null";
    }

    /**
     * 方式1.代理类工厂的方式,需要拿到对方的接口(接口名称，包路径必须相同)
     * @return
     * @throws Exception
     */
    @RequestMapping(value = "/cxf/rs")
    @ResponseBody
    public String cxfrs() throws Exception {
        try {
            // 接口地址
            String address = "http://localhost:9090/services/index?wsdl";
            // 代理工厂
            JaxWsProxyFactoryBean jaxWsProxyFactoryBean = new JaxWsProxyFactoryBean();
            // 设置代理地址
            jaxWsProxyFactoryBean.setAddress(address);
            // 设置接口类型
            jaxWsProxyFactoryBean.setServiceClass(IndexService.class);
            jaxWsProxyFactoryBean.getOutInterceptors().add(new AuthInterceptor());
            // 创建一个代理接口实现
            IndexService cs = (IndexService) jaxWsProxyFactoryBean.create();
            // 数据准备
            String userName = "hello";
            // 调用代理接口的方法调用并返回结果
            String result = cs.index(userName);
            System.out.println("返回结果:" + result);
            return result;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return "result_null";
    }

    @RequestMapping(value = "/cxf/web")
    @ResponseBody
    public String webclient() throws Exception {

        String endpoint = "http://localhost:9090/services/info";
        String namespace = "http://service.mserver.com/";
        String operation = "index";
        //访问地址
        WebClient client = WebClient.create("http://localhost:9090/services");
        //服务路径，及参数
        client.path("/info");
        //接受类型
        //client.accept();
        ClientConfiguration config = WebClient.getConfig(client);
        config.getHttpConduit().getClient().setReceiveTimeout(30000);
        //发送内容,返回类型
        String response = client.post("123",String.class);

        return response;
    }
}
