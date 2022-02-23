using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Exploud Specie to store common natural stats of every {'abilities': ['soundproof', 'scrappy'], 'base_experience': 221, 'height': 15, 'id': 295, 'moves': ['pound', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'stomp', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'bite', 'roar', 'supersonic', 'flamethrower', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'low-kick', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'earthquake', 'toxic', 'mimic', 'screech', 'double-team', 'defense-curl', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'outrage', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'psych-up', 'shadow-ball', 'rock-smash', 'whirlpool', 'uproar', 'torment', 'facade', 'taunt', 'brick-break', 'endeavor', 'secret-power', 'hyper-voice', 'astonish', 'overheat', 'rock-tomb', 'howl', 'shock-wave', 'water-pulse', 'natural-gift', 'fling', 'focus-blast', 'giga-impact', 'avalanche', 'thunder-fang', 'ice-fang', 'fire-fang', 'zen-headbutt', 'rock-climb', 'captivate', 'smack-down', 'synchronoise', 'round', 'echoed-voice', 'incinerate', 'retaliate', 'bulldoze', 'work-up', 'boomburst', 'confide', 'power-up-punch'], 'name': 'exploud', 'stats': {'hp': 104, 'attack': 91, 'defense': 63, 'special-attack': 91, 'special-defense': 73, 'speed': 68}, 'types': ['normal'], 'weight': 840, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': 'cave', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'ground'], 'names': {'ja-Hrkt': 'バクオング', 'roomaji': 'Bakuong', 'ko': '폭음룡', 'zh-Hant': '爆音怪', 'fr': 'Brouhabam', 'de': 'Krawumms', 'es': 'Exploud', 'it': 'Exploud', 'en': 'Exploud', 'ja': 'バクオング', 'zh-Hans': '爆音怪'}, 'genera': {'ja-Hrkt': 'そうおんポケモン', 'ko': '소음포켓몬', 'zh-Hant': '噪音寶可夢', 'fr': 'Pokémon Bruit Sourd', 'de': 'Krach', 'es': 'Pokémon Escandaloso', 'it': 'Pokémon Fragore', 'en': 'Loud Noise Pokémon', 'ja': 'そうおんポケモン', 'zh-Hans': '噪音宝可梦'}}
	public class SpecieExploud : PokemonSpecie
	{
#nullable enable
		private static SpecieExploud? _instance = null;
#nullable restore
        public static SpecieExploud Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieExploud();
                }
                return _instance;
            }
        }

		public SpecieExploud() : base(
			"Exploud",
			104, // HPs
			91, 63, // Attack & Defense
			91, 73, // Special Attack & Defense
			68			
		) {}
	}


	//Exploud Pokemon Class
	public class Exploud : Pokemon
	{

		public Exploud(string nickname, int level) : base(
			295,
			SpecieExploud.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Exploud() : base(
			295,
			SpecieExploud.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}