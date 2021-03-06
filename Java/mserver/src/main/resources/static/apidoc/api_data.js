define({ "api": [
  {
    "type": "get,post,put,delete",
    "url": "/index?wsdl",
    "title": "查询用户信息",
    "version": "1.6.2",
    "name": "____",
    "group": "User",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "Number",
            "optional": false,
            "field": "id",
            "description": "<p>用户唯一ID.</p>"
          }
        ]
      }
    },
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "xing",
            "description": "<p>姓.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "name",
            "description": "<p>名字.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "查询成功:",
          "content": "HTTP/1.1 200 OK\n{\n  \"xing\": \"陈\",\n  \"name\": \"义亮\"\n}",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "UserNotFound",
            "description": "<p>没有查询到ID用户.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "查询失败:",
          "content": "HTTP/1.1 404 Not Found\n{\n  \"error\": \"UserNotFound\"\n}",
          "type": "json"
        }
      ]
    },
    "filename": "myapp/test.java",
    "groupTitle": "User"
  },
  {
    "type": "get",
    "url": "/index?wsdl",
    "title": "查询用户信息",
    "version": "0.0.1",
    "name": "____",
    "group": "User",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "Number",
            "optional": false,
            "field": "id",
            "description": "<p>用户唯一ID.</p>"
          },
          {
            "group": "Parameter",
            "type": "xing",
            "optional": false,
            "field": "xing",
            "description": "<p>姓.</p>"
          },
          {
            "group": "Parameter",
            "type": "name",
            "optional": false,
            "field": "name",
            "description": "<p>名字.</p>"
          }
        ]
      }
    },
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "xing",
            "description": "<p>姓.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "name",
            "description": "<p>名字.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "查询成功:",
          "content": "HTTP/1.1 200 OK\n{\n  \"xing\": \"陈\",\n  \"name\": \"义亮\"\n}",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "UserNotFound",
            "description": "<p>没有查询到ID用户.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "查询失败:",
          "content": "HTTP/1.1 404 Not Found\n{\n  \"error\": \"UserNotFound\"\n}",
          "type": "json"
        }
      ]
    },
    "filename": "myapp/test1.java",
    "groupTitle": "User"
  }
] });
