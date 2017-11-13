<template>
  <div>
    <input type='text' v-model='seconds'>
    <b-progress :value="progress" :max="max" show-progress animated></b-progress>
    <button v-on:click='start()'>start</button>
  </div>
</template>

<script>
export default {
  name: 'countdown',
  data () {
    return {
      progress: 0,
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
      /* this.progress skal opdateres */
      if (true/* when to stop?*/) {
        return
      }
      // her genstarter vi ved at sætte et timeout, der kalder samme funktion igen om 100 ms
      setTimeout(this.updateProgress, 100)
    }
  }
}
</script>
