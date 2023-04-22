import React from 'react'
import imgPerro from "../../assets/images/imgPerro.png"

<<<<<<< HEAD
const FirstBlock = () => {
  return (
    <div className="mt-4 w-[328px] h-[275px] ml-4 ">
        <img src={imgPerro} alt="perro" className="mt-6" />
        <p className="mt-4 ml-4 text-gray-150">{"{Raza}"}</p>
        <p className="mt-2 text-[24px]">
          {"{nombre de la"} <br />
          {"mascota}"}
        </p>
        <p className="mt-2 text-gray-150">
          {"{Sexo}"}°{"{Edad}"}°{"{Peso}"}
        </p>
=======
const FirstBlock = ({prop}) => {
  return (
    <div className="mt-4 w-[328px] h-[275px] ml-4">
        <img src={prop?.urlFotoPerfil} alt="perro" className="mt-6 rounded-full" />
        
        <p className="mt-2 text-[24px]">
          {prop?.nombre}
        </p>
        <p className="mt-2 text-gray-150">
          {"E-mail :" + prop?.email}
        </p>
        <p className="mt-2 text-gray-150">
        {"Calle : "+ (prop?.calle ? prop.calle : "")}
        </p>
        {/* <p className="mt-2 text-gray-150">
        { "Ciudad: " + "direccion.ciudad"}
        </p> */}
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
      </div>
  )
}

export default FirstBlock