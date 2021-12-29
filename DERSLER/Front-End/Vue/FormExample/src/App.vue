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
                    <input type="text" id="username" class="form-control">
                  </div>
                  <div class="form-group">
                    <label for="password">Şifre</label>
                    <input type="password" id="password" class="form-control">
                  </div>
                  <div class="form-group">
                    <label for="age">Yaş</label>
                    <input type="number" id="age" class="form-control">
                  </div>
                </div>
              </div>
              <div class="row">
                <div class="col-md-12 form-group">
                  <label for="message">Açıklama</label><br>
                  <textarea id="message" rows="3" class="form-control"></textarea>
                </div>
              </div>
              <div class="row">
                <div class="col-md-12">
                  <div class="form-group">
                    <label>
                      <input type="checkbox" value="yazilim"> Yazılım
                    </label>
                    <label>
                      <input type="checkbox" value="donanim"> Donanım
                    </label>
                  </div>

                </div>
              </div>
              <div class="row">
                <div class="col-md-12 form-group">
                  <label>
                    <input type="radio" value="erkek"> Erkek
                  </label>
                  <label>
                    <input type="radio" value="kadin"> Kadın
                  </label>
                </div>
              </div>
              <div class="row">
                <div class="col-md-12 from-group">
                  <label>Şehir</label>
                  <select class="form-control">
                    <option></option>
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
              <p>Kullanıcı Adı:</p>
              <p>Şifre:</p>
              <p>Yaş:</p>
              <p>Açıklama: </p>
              <p><strong>İlgi Alanları</strong></p>
              <ul>
                <li></li>
              </ul>
              <p>Cinsiyet:</p>
              <p>Şehir:</p>
              <p>Toggle:</p>
            </div>
          </div>
      </div>
    </div>

  </div>
</template>

<script>
  export default {}
</script>

<style>

</style>
