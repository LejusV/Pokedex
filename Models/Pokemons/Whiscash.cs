using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Whiscash Specie to store common natural stats of every {'abilities': ['oblivious', 'anticipation', 'hydration'], 'base_experience': 164, 'height': 9, 'id': 340, 'moves': ['headbutt', 'thrash', 'double-edge', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'earthquake', 'fissure', 'toxic', 'mimic', 'double-team', 'waterfall', 'amnesia', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'magnitude', 'hidden-power', 'rain-dance', 'future-sight', 'rock-smash', 'whirlpool', 'hail', 'facade', 'secret-power', 'dive', 'mud-sport', 'rock-tomb', 'tickle', 'muddy-water', 'bounce', 'water-sport', 'water-pulse', 'natural-gift', 'aqua-tail', 'earth-power', 'giga-impact', 'mud-bomb', 'zen-headbutt', 'stone-edge', 'captivate', 'round', 'scald', 'bulldoze', 'belch', 'confide'], 'name': 'whiscash', 'stats': {'hp': 110, 'attack': 78, 'defense': 73, 'special-attack': 76, 'special-defense': 71, 'speed': 60}, 'types': ['water', 'ground'], 'weight': 236, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'blue', 'shape': 'fish', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['water2'], 'names': {'ja-Hrkt': 'ナマズン', 'roomaji': 'Namazun', 'ko': '메깅', 'zh-Hant': '鯰魚王', 'fr': 'Barbicha', 'de': 'Welsar', 'es': 'Whiscash', 'it': 'Whiscash', 'en': 'Whiscash', 'ja': 'ナマズン', 'zh-Hans': '鲶鱼王'}, 'genera': {'ja-Hrkt': 'ひげうおポケモン', 'ko': '수염물고기포켓몬', 'zh-Hant': '鬚魚寶可夢', 'fr': 'Pokémon Barbillon', 'de': 'Barthaar', 'es': 'Pokémon Bigotudo', 'it': 'Pokémon Baffetti', 'en': 'Whiskers Pokémon', 'ja': 'ひげうおポケモン', 'zh-Hans': '须鱼宝可梦'}}
	public class SpecieWhiscash : PokemonSpecie
	{
#nullable enable
		private static SpecieWhiscash? _instance = null;
#nullable restore
        public static SpecieWhiscash Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWhiscash();
                }
                return _instance;
            }
        }

		public SpecieWhiscash() : base(
			"Whiscash",
			110, // HPs
			78, 73, // Attack & Defense
			76, 71, // Special Attack & Defense
			60			
		) {}
	}


	//Whiscash Pokemon Class
	public class Whiscash : Pokemon
	{

		public Whiscash(string nickname, int level) : base(
			340,
			SpecieWhiscash.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Ground.Instance			
		) {}

		public Whiscash() : base(
			340,
			SpecieWhiscash.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
	}
}