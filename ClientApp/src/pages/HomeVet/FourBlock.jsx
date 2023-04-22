<<<<<<< HEAD
import React from 'react'

const FourBlock = () => {
=======
import React, { useEffect, useState } from 'react'
import { getTratamiento } from '../../services/tratamiento';

const FourBlock = () => {

  const [Tratamientos, setTratamientos] = useState([]);

  const getApi = async ()=>{
    let response = await getTratamiento(1)
    let p = Tratamientos
    p.push(response)
    setTratamientos(p)
  }
  console.log(Tratamientos)
  useEffect(() => {
    getApi()
  }, []);

  if(Tratamientos.length === 0){
    return <div></div>
  }
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
  return (
    <div className="flex flex-col mt-8">
  <div className="overflow-x-auto sm:-mx-6 lg:-mx-8">
    <div className="inline-block min-w-full py-2 sm:px-6 lg:px-8">
      <div className="overflow-hidden">
        <table className="min-w-full text-left text-sm font-light">
          <thead className="border-b font-medium dark:border-neutral-500">
            <tr>
              <th scope="col" className="px-1 py-2">Paciente</th>
              <th scope="col" className="px-1 py-2">Última Consulta</th>
              <th scope="col" className="px-1 py-2">Tratamiento</th>
              <th scope="col" className="px-1 py-2">Observaciones</th>
            </tr>
          </thead>
          <tbody>
<<<<<<< HEAD
            <tr className="border-b dark:border-neutral-500">
              <td className="whitespace-nowrap px-2 py-4 font-medium">Tobi</td>
              <td className="whitespace-nowrap px-2 py-4">06/05/23</td>
              <td className="whitespace-nowrap px-2 py-4">11/12/23</td>
              <td className="whitespace-nowrap px-2 py-4">Pulgoso</td>
            </tr>
            <tr className="border-b dark:border-neutral-500">
              <td className="whitespace-nowrap px-2 py-4 font-medium">Thor</td>
              <td className="whitespace-nowrap px-2 py-4">03/03/23</td>
              <td className="whitespace-nowrap px-2 py-4">05/06/23</td>
              <td className="whitespace-nowrap px-2 py-4">Rabioso</td>
            </tr>
            <tr className="border-b dark:border-neutral-500">
              <td className="whitespace-nowrap px-2 py-4 font-medium">Larry</td>
              <td className="whitespace-nowrap px-2 py-4">02/02/23</td>
              <td className="whitespace-nowrap px-2 py-4">07/08/23</td>
              <td className="whitespace-nowrap px-2 py-4">Obesidad</td>
            </tr>
=======
            {
              Tratamientos.map(m => (
                <tr className="border-b dark:border-neutral-500">
                  <td className="whitespace-nowrap px-2 py-4 font-medium">Tobi</td>
                  <td className="whitespace-nowrap px-2 py-4">06/05/23</td>
                  <td className="whitespace-nowrap px-2 py-4">11/12/23</td>
                  <td className="whitespace-nowrap px-2 py-4">Pulgoso</td>
                </tr>
              ))
            }
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
          </tbody>
        </table>
      </div>
    </div>
  </div>
</div>
  )
}

export default FourBlock