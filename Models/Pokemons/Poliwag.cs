using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Poliwag Specie to store common natural stats of every {'abilities': ['water-absorb', 'damp', 'swift-swim'], 'base_experience': 60, 'height': 6, 'id': 60, 'moves': ['double-slap', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'mist', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'dig', 'toxic', 'psychic', 'hypnosis', 'rage', 'mimic', 'double-team', 'defense-curl', 'haze', 'bide', 'waterfall', 'skull-bash', 'amnesia', 'bubble', 'psywave', 'splash', 'rest', 'substitute', 'thief', 'mind-reader', 'snore', 'curse', 'protect', 'belly-drum', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'hidden-power', 'rain-dance', 'whirlpool', 'hail', 'facade', 'helping-hand', 'endeavor', 'refresh', 'secret-power', 'dive', 'ice-ball', 'mud-shot', 'water-sport', 'water-pulse', 'wake-up-slap', 'natural-gift', 'mud-bomb', 'captivate', 'round', 'scald', 'confide'], 'name': 'poliwag', 'stats': {'hp': 40, 'attack': 50, 'defense': 40, 'special-attack': 40, 'special-defense': 40, 'speed': 90}, 'types': ['water'], 'weight': 124, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'blue', 'shape': 'legs', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'ニョロモ', 'roomaji': 'Nyoromo', 'ko': '발챙이', 'zh-Hant': '蚊香蝌蚪', 'fr': 'Ptitard', 'de': 'Quapsel', 'es': 'Poliwag', 'it': 'Poliwag', 'en': 'Poliwag', 'ja': 'ニョロモ', 'zh-Hans': '蚊香蝌蚪'}, 'genera': {'ja-Hrkt': 'おたまポケモン', 'ko': '올챙이포켓몬', 'zh-Hant': '蝌蚪寶可夢', 'fr': 'Pokémon Têtard', 'de': 'Kaulquappe', 'es': 'Pokémon Renacuajo', 'it': 'Pokémon Girino', 'en': 'Tadpole Pokémon', 'ja': 'おたまポケモン', 'zh-Hans': '蝌蚪宝可梦'}}
	public class SpeciePoliwag : PokemonSpecie
	{
#nullable enable
		private static SpeciePoliwag? _instance = null;
#nullable restore
        public static SpeciePoliwag Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePoliwag();
                }
                return _instance;
            }
        }

		public SpeciePoliwag() : base(
			"Poliwag",
			40, // HPs
			50, 40, // Attack & Defense
			40, 40, // Special Attack & Defense
			90			
		) {}
	}


	//Poliwag Pokemon Class
	public class Poliwag : Pokemon
	{

		public Poliwag(string nickname, int level) : base(
			60,
			SpeciePoliwag.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Poliwag() : base(
			60,
			SpeciePoliwag.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}