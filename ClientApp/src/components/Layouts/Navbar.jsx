import React from 'react'
import {Dog, UserCircle} from "@phosphor-icons/react";

const Navbar = () => {
    return (
        
            <nav className="mx-auto flex justify-between w-full bg-slate-200">
                <div className="text-2xl cursor-pointer ">
                   <Dog size={40} />
                </div>
                <div className=" cursor-pointer">
                    <UserCircle size={40}/>
                </div>
            </nav>

        
    )
}

export default Navbar