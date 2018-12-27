import axios from 'axios'

export const http = axios.create({
  baseURL: 'https://localhost:5001/api/organismo/',
  timeout: 20000,
  withCredentials: false
})
