package com.mclient.axis;

import com.mclient.axis.common.Client;
import com.mclient.axis.common.SOAPHead;
import com.mclient.axis.entity.Result;
import org.apache.axis.Constants;
import org.apache.axis.Message;
import org.apache.axis.client.Call;
import org.apache.axis.client.Service;
import org.apache.axis.encoding.XMLType;
import org.apache.axis.encoding.ser.BeanDeserializerFactory;
import org.apache.axis.encoding.ser.BeanSerializerFactory;
import org.apache.axis.message.PrefixedQName;
import org.apache.axis.message.SOAPHeaderElement;
import org.apache.axis.transport.http.HTTPConstants;
import org.apache.axis.utils.Options;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;

import javax.ws.rs.POST;
import javax.xml.namespace.QName;
import javax.xml.rpc.ParameterMode;
import javax.xml.soap.Name;
import javax.xml.soap.SOAPMessage;
import javax.xml.stream.XMLStreamWriter;
import javax.xml.ws.EndpointReference;
import java.util.HashMap;
import java.util.Map;

/**
 * Created by cyl on 2017/10/10.
 */
@Controller
@RequestMapping(value = "/")
public class AXISClient {
    private static final Logger LOG = LoggerFactory.getLogger(AXISClient.class);

    @GetMapping(value = "/axis")
    @ResponseBody
    public String axis(String msg){
        try {
            //表示一个服务端
            //JAX-WS方式发布的服务
            String endpoint = "http://localhost:9090/services/index?wsdl";
            //JAX-RS方式发布的服务
            //String endpoint = "http://localhost:9090/services/info";
            //创建调用过程
            Service service = new Service();
            Call call = (Call) service.createCall();
            //设置调用的服务url
            call.setTargetEndpointAddress(new java.net.URL(endpoint));
            //设置调用服务中要执行的操作
            call.setOperationName(new QName("http://service.mserver.com/","index"));// WSDL里面描述的操作名称
            //call.setProperty(org.apache.axis.client.Call.CHECK_MUST_UNDERSTAND, Boolean.FALSE);
            //单个参数可以不设置，如果设置参数名称要和服务端的@webparam规定的名称一致
            //设置参数 1名称，2参数类型，3(输入参数或输出参数，是在生成的soap消息(xml)中的包裹参数的元素不同)
            //多个参数传递按照参数添加顺序与参数数组对应，类似于sql语句中的占位符和参数对应
            call.addParameter("msg",XMLType.XSD_STRING,ParameterMode.IN);// 操作的参数
            //添加请求头，服务端在soap消息头部进行验证
            //使用soap协议发送消息(一个xml)
            //与cxf方式不同再添加头部信息时不能随意创建xml的文档及元素，否则服务端可能不认识这些创建的元素
            Name headerName = new PrefixedQName(new QName("http://service.mserver.com/", "index"));
            SOAPHeaderElement head = new SOAPHeaderElement(headerName);
            head.addChildElement("username").addTextNode("admin");
            head.addChildElement("password").addTextNode("123");
            //head.setAttribute("method","post");
            call.addHeader(head);
            //设置希望服务返回的数据类型，setReturnClass 设置返回的java类
            //call.setReturnClass(String.class);
            call.setReturnType(org.apache.axis.encoding.XMLType.XSD_STRING);
            call.setUseSOAPAction(true);
            // 给方法传递参数，并且调用方法
            String temp = msg == null || msg.length() == 0?"good" : msg;
            Object[] obj = new Object[] { temp };
            String result = (String) call.invoke(obj);
            System.out.println("Result is : " + result);
            return result;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return "result_null";
    }


    @GetMapping(value = "/axis/obj")
    @ResponseBody
    public Result axisObj() {
        try {
            String endpoint = "http://localhost:9090/services/index?wsdl";
            String namespace = "http://service.mserver.com/";
            String operation = "testObj";
            Call call = Client.createCall(endpoint,namespace,operation);

            Map<String, String> param = new HashMap<>();
            param.put("username","admin");
            param.put("password","123");
            SOAPHeaderElement head = SOAPHead.createHead(namespace,operation,param);
            call.addHeader(head);

            call.addParameter("width", XMLType.XSD_STRING, ParameterMode.IN);//这里的username为传入参数的变量名字
            call.addParameter("height", XMLType.SOAP_STRING, ParameterMode.IN);//这里的units为传入参数的变量名字
            call.addParameter("name", XMLType.SOAP_STRING, ParameterMode.IN);//这里的code为传入参数的变量名字
            call.setReturnClass(Result.class);
            // 注册映射关系
            QName reflect = new QName(namespace, operation);//此处的 operation为WSDL文件中complexType name的属性值
            //这里注册映射关系，对自定义的类进行序列化与反序列化。
            call.registerTypeMapping(Result.class, reflect,new BeanSerializerFactory(Result.class, reflect), new BeanDeserializerFactory(Result.class, reflect));
            Result obj = (Result) call.invoke(new Object[]{"100", "500", "android"});//接口接收的参数
            return obj;
            } catch(Exception e){
                e.printStackTrace();
            }
           return null;
    }
    
}
