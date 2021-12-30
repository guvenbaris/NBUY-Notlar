<template>
  <div class="container">
    <h3>Form Verileriyle Çalışmak</h3>
    <hr>
    <div class="row">
      <div class="col-md-6">
        <div class="panel panel-warning">
          <div class="panel-heading">
            <h4>Başvuru Formu</h4>
          </div>
          <div class="panel-body">
            <form>
              <div class="row">
                <div class="col-md-12">
                  <div class="form-group">
                    <label for="email">Kullanıcı Adı</label>
                    <input type="text" id="username" class="form-control" v-model="userData.userName">
                  </div>
                  <div class="form-group">
                    <label for="password">Şifre</label>
                    <input type="password" id="password" class="form-control" v-model="userData.password">
                  </div>
                  <div class="form-group">
                    <label for="age">Yaş</label>
                    <input type="number" id="age" class="form-control" v-model="userData.age">
                  </div>
                </div>
              </div>
              <div class="row">
                <div class="col-md-12 form-group">
                  <label for="message">Açıklama</label><br>
                  <textarea id="message" rows="3" class="form-control" v-model="userData.message"></textarea>
                </div>
              </div>
              <div class="row">
                <div class="col-md-12">
                  <div class="form-group">
                    <label>
                      <input type="checkbox" value="yazilim" v-model="userData.interests"> Yazılım 
                    </label>
                    <label>
                      <input type="checkbox" value="donanim"  v-model="userData.interests"> Donanım
                    </label>
                  </div>

                </div>
              </div>
              <div class="row">
                <div class="col-md-12 form-group">
                  <label>
                    <input type="radio" value="erkek" v-model="userData.gender"> Erkek
                  </label>
                  <label>
                    <input type="radio" value="kadin" v-model="userData.gender"> Kadın
                  </label>
                </div>
              </div>
              <div class="row">
                <div class="col-md-12 from-group">
                  <label >Şehir</label>
                  <select class="form-control" v-model="userData.selectedCity">
                    <option v-for="city in userData.cities" :key="city">{{city}}</option>
                  </select>
                </div>
              </div>
              <hr>
              <div class="row">
                <div class="col-md-12">
                  <button
                    class="btn btn-primary">Gönder!
                  </button>
                </div>
              </div>
            </form>
          </div>
        </div>
      </div>
      <div class="col-md-6">
          <div class="panel panel-info">
            <div class="panel-heading">
              <h4>Form Verileri</h4>
            </div>
            <div class="panel-body">
              <p>Kullanıcı Adı:{{userData.userName}}</p>
              <p>Şifre:{{userData.password}}</p>
              <p>Yaş:{{userData.age}}</p>
              <p>Açıklama:{{userData.message}} </p>
              <p><strong>İlgi Alanları</strong></p>
              <ul>
                <li v-for="interest in userData.interests" :key="interest">{{interest}}</li>
              </ul>
              <p>Cinsiyet:{{userData.gender}}</p>
              <p>Şehir:{{userData.selectedCity}}</p>
              <p>Toggle:</p>
            </div>
          </div>
      </div>
    </div>

  </div>
</template>

<script>
  export default {
    data(){
      return {
        userData:{
          userName:'',
          password:'',
          age:null,
          message:'',
          interests:[],
          gender:'',
          cities:["İstanbul","Sakarya","Bursa","Bingöl"],
          selectedCity:'',
        }
      }
    }
  }
</script>

<style>

</style>
