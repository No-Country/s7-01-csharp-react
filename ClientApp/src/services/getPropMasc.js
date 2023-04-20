import axios from "axios";
import { BASE_URL } from "../const/backend";

export const getPropMasc = async(id)=> {   
 const ruta = `${BASE_URL}Propietario/${id}`
 const ruta2 =  `${BASE_URL}Mascota/getForPropietarie/${id}`
 const respuesta = await axios.get(ruta)
 const respuesta2 = await axios.get(ruta2)
 
 return {
    prop : respuesta.data,
    mascota : respuesta2.data.result
    }
}