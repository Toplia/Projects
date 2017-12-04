package com.mclient.axis.common;

import org.apache.axis.client.Call;
import org.apache.axis.client.Service;

import javax.xml.namespace.QName;
import javax.xml.rpc.ServiceException;
import java.net.MalformedURLException;

/**
 * Created by cyl on 2017/10/11.
 */
public class Client {

    public static Call createCall(String endpoint,String namespace,String operation) throws ServiceException, MalformedURLException {
        if(endpoint == null || endpoint.trim().length() == 0){
            throw new NullPointerException("endpoint is null");
        }
        if(namespace == null || namespace.trim().length() == 0){
            throw new NullPointerException("namespace is null");
        }
        if(operation == null || operation.trim().length() == 0){
            throw new NullPointerException("operation is null");
        }
        Service service = new Service();
        Call call = (Call) service.createCall();
        //设置调用的服务url
        call.setTargetEndpointAddress(new java.net.URL(endpoint));
        //设置调用服务中要执行的操作
        call.setOperationName(new QName(namespace,operation));
        return call;
    }
}
