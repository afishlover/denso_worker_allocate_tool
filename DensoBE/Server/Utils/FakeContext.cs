﻿using Newtonsoft.Json;
using Server.Models;

namespace Server.Utils
{
    public class FakeContext
    {
        private List<WorkerModel> Workers = new List<WorkerModel>();
        public FakeContext()
        {
            var workerStr = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), @"Localdb/worker.json"));
            Workers = JsonConvert.DeserializeObject<List<WorkerModel>>(workerStr);
        }

        #region Worker
        public List<WorkerModel> GetAllWorkers()
        {
            return Workers;
        }

        public List<WorkerModel> GetWorkerById(string id)
        {
            return Workers.FindAll(w => w.WorkerId.Equals(id.ToLower()));
        }

        public bool CreateWorker(WorkerModel worker)
        {
            try
            {
                Workers.Add(worker);
                var workerStr = JsonConvert.SerializeObject(Workers, Formatting.Indented);
                File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), @"Localdb/worker.json"), workerStr);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}