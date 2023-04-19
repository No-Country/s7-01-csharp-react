import React from 'react'
import imgPerro from "../../assets/images/imgPerro.png"

const FirstBlock = () => {
  return (
    <div className="mt-4 w-[328px] h-[275px] ml-4 ">
        <img src={imgPerro} alt="perro" className="mt-6" />
        
        <p className="mt-2 text-[24px]">
          {"{nombre de"} <br />
          {"propietario}"}
        </p>
        <p className="mt-2 text-gray-150">
          {"E-mail :" + " propietario.e-mail "}
        </p>
        <p className="mt-2 text-gray-150">
        {"Calle : direccion.calle"+" direccion.numero"}
        </p>
        <p className="mt-2 text-gray-150">
        { "Ciudad: " + "direccion.ciudad"}
        </p>
      </div>
  )
}

export default FirstBlock