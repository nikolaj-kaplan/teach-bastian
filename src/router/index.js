import Vue from 'vue'
import Router from 'vue-router'
import Hello from '@/components/Hello'
import Countdown from '@/components/Countdown'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Hello',
      component: Hello
    },
    {
      path: '/Countdown',
      name: 'Countdown',
      component: Countdown
    }
  ]
})
