package com.gab.Server.controllers;

import com.gab.Server.entity.Curse;
import com.gab.Server.repositories.CurseRepository;
import com.gab.Server.requestors.Requestor;
import com.gab.Server.services.CurseService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.scheduling.annotation.Scheduled;
import org.springframework.util.StringUtils;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("/")
public class CurrencyController {
    
    @Autowired
    @Qualifier("requestor")
    private Requestor requestor;
    
    @Autowired
    private CurseService curseService;
    
    @GetMapping("/currency")
    @ResponseBody
    public String getCurrency() {
    
        
        return curseService.findLast().getJsonData();
    }

    @Scheduled(cron = "@hourly")
    public void updateCurse() {

        String jsonData = requestor.getCurse();
        if(!StringUtils.isEmpty(jsonData)) {
            Curse curse = new Curse(jsonData);
            curseService.save(curse);
        }
    }
}
