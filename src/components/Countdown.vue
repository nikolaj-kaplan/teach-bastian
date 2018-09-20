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
/* eslint-disable */
export default {
  name: 'countdown',
  data () {
    return {
      progress: 10,
      max: 100,
      seconds: 0,
      startTime: undefined,
      running: false
    }
  },
  methods: {
    start () {
      this.startTime = new Date().getTime()
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
      // her genstarter vi ved at sætte et timeout, der kalder samme funktion igen om 100 ms
      setTimeout(this.updateProgress, 100)
    }
  }
}
/* eslint-enable */
</script>
