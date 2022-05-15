package com.gab.Server.services;

import com.gab.Server.entity.Curse;
import com.gab.Server.repositories.CurseRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class CurseService {
    
    @Autowired
    private CurseRepository curseRepository;
    
    public List<Curse> findAll() {
        
        return curseRepository.findAll();
    }
    
    public void save(Curse curse) {
        
        curseRepository.save(curse);
    }
    
    public List<Curse> findOrderByDateDesc() {
        
        return curseRepository.findOrderByDateDesc();
    }
    
    public Curse findLast() {
        
        return curseRepository.findLast();
    }
}
