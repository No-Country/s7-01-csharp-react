<<<<<<< HEAD
import { useState,useEffect } from "react"
import { getAllClinics } from "../services/getAllClinics"
import { getAllServices } from "../services/getAllService"



export function useAllClinics() {
    const [clinicas, setClinicas] = useState([])
    const [services, setServices] = useState([])
    useEffect(() => {
        getClinicas()
        getServicios()
    }, [])
    const getClinicas = async () => {
        try {
            const res = await getAllClinics()            
            setClinicas(res.result)
        } catch (error) {
            console.log(error)
        }
    }
    const getServicios = async () =>{
        try {
            const res = await getAllServices()
            console.log(res)            
            setServices(res)
        } catch (error) {
            console.log(error)
        }
    }
    return {clinicas,services}
}

=======
import { useState, useEffect } from "react";
import { getAllClinics } from "../services/getAllClinics";
import { getAllServices } from "../services/getAllService";

export function useAllClinics() {
  const [clinicas, setClinicas] = useState([]);
  const [services, setServices] = useState([]);
  useEffect(() => {
    getClinicas();
    getServicios();
  }, []);
  const getClinicas = async () => {
    try {
      const res = await getAllClinics();
      setClinicas(res.result);
    } catch (error) {
      console.log(error);
    }
  };
  const getServicios = async () => {
    try {
      const res = await getAllServices();
      //   console.log(res)
      setServices(res);
    } catch (error) {
      console.log(error);
    }
  };
  return { clinicas, services };
}
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
