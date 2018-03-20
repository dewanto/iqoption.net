﻿using iqoptionapi.http;
using iqoptionapi.models;
using RestSharp;

namespace iqoptionapi.http {
    public class LoginV2Request : IqOptionRequest {
        public LoginV2Request(LoginModel loginModel) : base("login", Method.POST) {
            this.AddParameter("email", loginModel.email);
            this.AddParameter("password", loginModel.password);
           
        }
    }
}