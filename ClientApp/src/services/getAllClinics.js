import axios from "axios";
import { BASE_URL } from "../const/backend";

export const getAllClinics = async()=> {   
 const ruta = `${BASE_URL}Veterinaria`  
 const respuesta = await axios.get(ruta)
 return respuesta.data
}

