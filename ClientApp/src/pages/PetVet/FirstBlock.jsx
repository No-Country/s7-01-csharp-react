import React from 'react'
import imgPerro from "../../assets/images/imgPerro.png"

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
      </div>
  )
}

export default FirstBlock