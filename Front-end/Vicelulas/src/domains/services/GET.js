import axios from 'axios'

axios.get('/endpoint-da-api')
  .then(function (response) {
    // Cuida da Resposta
    console.log(response)
  })
  .catch(function (error) {
    // Cuida dos Erros
    console.log(error)
  })
  .then(function () {
    // sempre é executada
  })

async function getUser () {
  try {
    const response = await axios.get('/endpoint-assincrono')
    console.log(response)
  } catch (error) {
    console.log(error)
  }
}

getUser()

axios.get('/user/12345')
  .catch(function (error) {
    if (error.response) {
      console.log(error.response.data)
      console.log(error.response.status)
      console.log(error.response.headers)
    } else if (error.request) {
      console.log(error.request)
    } else {
      console.log('Error', error.message)
    }
    console.log(error.config)
  })
