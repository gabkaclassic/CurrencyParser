package com.gab.Server.requestors;

import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Service;
import org.springframework.web.reactive.function.client.WebClient;

@Service("requestor")
public class Requestor {

    @Value("${url}")
    private String URL;
    
    private WebClient client = WebClient.create();

    public String getCurse() {
        
        return client.get().uri(URL)
                .retrieve().bodyToMono(String.class).block();
    }
    
}
