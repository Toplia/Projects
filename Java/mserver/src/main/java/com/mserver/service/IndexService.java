package com.mserver.service;

import com.common.Result;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;

/**
 * Created by cyl on 2017/10/9.
 */
@WebService
public interface IndexService {

    @WebMethod
    public String index(@WebParam(name = "msg") String msg);

    public Result testObj(@WebParam(name = "width")String width, @WebParam(name = "height")String height, @WebParam(name = "name")String name);
}
