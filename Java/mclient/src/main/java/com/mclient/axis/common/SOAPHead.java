package com.mclient.axis.common;

import org.apache.axis.message.PrefixedQName;
import org.apache.axis.message.SOAPHeaderElement;

import javax.xml.namespace.QName;
import javax.xml.soap.Name;
import javax.xml.soap.SOAPException;
import java.util.Map;
import java.util.Set;

/**
 * Created by cyl on 2017/10/11.
 */
public class SOAPHead {

    public static SOAPHeaderElement createHead(String namespace, String operationName, Map<String,String> param) throws SOAPException {
        if(namespace == null || namespace.trim().length() == 0){
            throw new NullPointerException("namespace is null");
        }
        if(operationName == null || operationName.trim().length() == 0){
            throw new NullPointerException("operationName is null");
        }
        if(param == null || param.isEmpty()){
            throw new NullPointerException("param is null");
        }
        Name headerName = new PrefixedQName(new QName(namespace, operationName));
        SOAPHeaderElement head = new SOAPHeaderElement(headerName);
        Set<String> keys = param.keySet();
        for(String key : keys){
            head.addChildElement(key).addTextNode(param.get(key));
        }
        return head;
    }
}
