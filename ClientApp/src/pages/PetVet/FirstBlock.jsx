import React from 'react'
import imgPerro from "../../assets/images/imgPerro.png"

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
      </div>
  )
}

export default FirstBlock