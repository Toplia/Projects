package com.mserver.service.impl;

import com.common.Result;
import com.mserver.service.IndexService;

import javax.jws.WebService;

/**
 * Created by cyl on 2017/10/9.
 */
@WebService(
        serviceName = "IndexServiceImpl", portName = "IndexImpl",
        targetNamespace = "http://service.mserver.com/",
        endpointInterface = "com.mserver.service.IndexService"
)
public class IndexServiceImpl implements IndexService {

    @Override
    public String index(String msg){

        return msg;
    }

    @Override
    public Result testObj(String width, String height, String name) {

        return new Result(width,height,name);
    }


}
