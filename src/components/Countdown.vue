<template>
  <div>
    <input type='text' v-model='seconds'>
    <b-progress height='300px' :value="progress" :max="max" show-progress animated></b-progress>

    <button v-on:click='start()'>start</button>
    <h2 v-show='running'><b-badge>Running...</b-badge></h2>
    <h2>{{(this.progress/1000).toFixed(1)}}</h2>
  </div>
</template>

<script>
export default {
  name: 'countdown',
  data () {
    return {
      progress: 50,
      max: 100,
      seconds: 0,
      startTime: undefined,
      running: false
    }
  },
  methods: {
    start () {
      this.running = true
      this.startTime = new Date().getTime()
      this.max = 1000 * this.seconds
      this.progress = 0
      this.updateProgress()
    },
    updateProgress () {
      var now = new Date().getTime()
      this.progress = now - this.startTime
      if (this.progress >= this.max) {
        this.running = false
        this.progress = this.max
        return
      }
      setTimeout(this.updateProgress, 100)
    }
  }
}
</script>
