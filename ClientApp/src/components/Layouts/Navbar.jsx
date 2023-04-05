import React from 'react'
import Logo from "../../assets/images/Logo.svg"
import profilePic from "../../assets/images/profilePic.png"

const Navbar = () => {
<<<<<<< HEAD
    return (        
            <nav className="mx-auto flex justify-between w-full ">
                <div className="text-2xl cursor-pointer">
                  <img src={Logo} alt="Logo" className='w-[130px] h-[32] mt-2 ml-2 '/>
                </div>
                <div className="cursor-pointer">
                    <img src={profilePic} alt="profilePic" className='w-8 h-8 rounded-full mt-2 mr-2'/>
=======
    return (
        
            <nav className="mx-auto flex justify-between w-full bg-slate-200">
                <div className="text-2xl cursor-pointer">
                   <Dog size={40} />
                </div>
                <div className=" cursor-pointer bg-gree">
                    <UserCircle size={40}/>
>>>>>>> 892baca (fixeando tailwind)
                </div>
            </nav>        
    )
}

export default Navbar