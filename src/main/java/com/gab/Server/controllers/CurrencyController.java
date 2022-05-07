package com.gab.Server.controllers;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/")
public class CurrencyController {
    
    @GetMapping("/currency")
    public String getCurrency() {
        
        return "{\"name\":\"Euro\",\"cost\":158.2}";
    }
    
}
