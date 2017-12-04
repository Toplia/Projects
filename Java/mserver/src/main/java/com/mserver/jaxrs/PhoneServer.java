package com.mserver.jaxrs;

import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;
import org.springframework.stereotype.Component;

import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.Path;

/**
 * Created by cyl on 2017/10/10.
 * JAX-RS(restful风格的)方式实现的webserver
 * 若希望一个Java类能够处理REST请求，则这个类必须至少添加一个@Path("/")的annotation；对于方法，这个annotation是可选的，如果不添加，则继承类的定义。
 */

@Path(value = "/")
@Api(value = "手机服务",description = "jax-rs的webserver")
@Component//在配置自动扫描时（不是在@configration中发布服务）需要配置这个注解
public class PhoneServer {

    //@GET
    @POST
    @Path(value = "/info")
    @ApiOperation(value = "信息")
    public String info(String msg){

        return "is phone";
    }
}
