import React from 'react'
import { useState } from 'react'
import MultiSelect from "react-multiple-select-dropdown-lite";
import "react-multiple-select-dropdown-lite/dist/index.css";

const SearchBar = ({ posts, setSearchResults }) => {

    const [searchTerm, setSearchTerm] = useState('')
    const [value, setvalue] = useState("");

    const handleSubmit = (e) => e.preventDefault()

    const handleOnchange = (val) => setvalue(val);

    const options = [
        { value: "language", label: "Language" },
        { value: "location", label: "Location" },
        { value: "date", label: "Date" },
    ]

    const handleSearchChange = (e) => {
        setSearchTerm(e.target.value)

        if (!e.target.value) return setSearchResults(posts)

        const resultsArray = posts.filter(post => post.language.toLowerCase().includes(e.target.value.toLowerCase()))

        setSearchResults(resultsArray)
    }

    return (
        <div>
            <form onSubmit={handleSubmit}>
                <input className="border-2 border-gray-300 bg-white h-10 px-5 pr-16 rounded-lg text-sm focus:outline-none mt-5"
                    type="search" name="search" placeholder="Search" value={searchTerm} onChange={handleSearchChange} />
            </form>
            <div className={"justify-center flex mt-5"}>
                <MultiSelect
                    className="multi-select"
                    onChange={handleOnchange}
                    options={options}
                />
            </div>
        </div>
    )
}

export default SearchBar

