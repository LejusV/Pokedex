using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Toucannon Specie to store common natural stats of every {'abilities': ['keen-eye', 'skill-link', 'sheer-force'], 'base_experience': 218, 'height': 11, 'id': 733, 'moves': ['swords-dance', 'fly', 'fury-attack', 'growl', 'supersonic', 'peck', 'drill-peck', 'toxic', 'screech', 'double-team', 'rest', 'substitute', 'thief', 'protect', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'rock-smash', 'brick-break', 'feather-dance', 'hyper-voice', 'overheat', 'bullet-seed', 'aerial-ace', 'rock-blast', 'roost', 'pluck', 'u-turn', 'flash-cannon', 'smack-down', 'flame-charge', 'round', 'echoed-voice', 'work-up', 'confide', 'beak-blast'], 'name': 'toucannon', 'stats': {'hp': 80, 'attack': 120, 'defense': 75, 'special-attack': 75, 'special-defense': 75, 'speed': 60}, 'types': ['normal', 'flying'], 'weight': 260, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'black', 'shape': 'wings', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ドデカバシ', 'ko': '왕큰부리', 'zh-Hant': '銃嘴大鳥', 'fr': 'Bazoucan', 'de': 'Tukanon', 'es': 'Toucannon', 'it': 'Toucannon', 'en': 'Toucannon', 'ja': 'ドデカバシ', 'zh-Hans': '铳嘴大鸟'}, 'genera': {'ja-Hrkt': 'おおづつポケモン', 'ko': '대포포켓몬', 'zh-Hant': '銃炮寶可夢', 'fr': 'Pokémon Canon', 'de': 'Kanone', 'es': 'Pokémon Cañón', 'it': 'Pokémon Cannone', 'en': 'Cannon Pokémon', 'ja': 'おおづつポケモン', 'zh-Hans': '铳炮宝可梦'}}
	public class SpecieToucannon : PokemonSpecie
	{
#nullable enable
		private static SpecieToucannon? _instance = null;
#nullable restore
        public static SpecieToucannon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieToucannon();
                }
                return _instance;
            }
        }

		public SpecieToucannon() : base(
			"Toucannon",
			80, // HPs
			120, 75, // Attack & Defense
			75, 75, // Special Attack & Defense
			60			
		) {}
	}


	//Toucannon Pokemon Class
	public class Toucannon : Pokemon
	{

		public Toucannon(string nickname, int level) : base(
			733,
			SpecieToucannon.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance, Flying.Instance			
		) {}

		public Toucannon() : base(
			733,
			SpecieToucannon.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}