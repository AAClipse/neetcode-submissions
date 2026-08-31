public class TimeMap {
    private Dictionary<string, List<(int Time, string Value)>> faced;
    public TimeMap() {
        faced = new Dictionary<string, List<(int Time, string Value)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!faced.ContainsKey(key))
        {
            faced[key] = new List<(int Time, string Value)>();
        }
        faced[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        if (faced.TryGetValue(key, out var list)){
            int left = 0;
            int right = faced[key].Count - 1;
            int resulti = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (list[mid].Time == timestamp){
                    resulti = mid;
                    break;
                }
                else if (list[mid].Time < timestamp){
                    resulti = mid;
                    left = mid + 1;
                }
                else{
                    right = mid - 1;
                }
            }
            if (resulti != -1){
                return list[resulti].Value; 
            }
            else{
                return "";
            }
        } 
        else{
            return "";
        }
    }
}
