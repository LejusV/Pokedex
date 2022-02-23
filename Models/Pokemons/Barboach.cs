using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Barboach Specie to store common natural stats of every {'abilities': ['oblivious', 'anticipation', 'hydration'], 'base_experience': 58, 'height': 4, 'id': 339, 'moves': ['headbutt', 'take-down', 'thrash', 'double-edge', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'earthquake', 'fissure', 'toxic', 'mimic', 'double-team', 'waterfall', 'amnesia', 'rest', 'substitute', 'snore', 'flail', 'protect', 'mud-slap', 'icy-wind', 'sandstorm', 'endure', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'magnitude', 'hidden-power', 'rain-dance', 'future-sight', 'whirlpool', 'hail', 'facade', 'secret-power', 'dive', 'mud-sport', 'rock-tomb', 'muddy-water', 'bounce', 'mud-shot', 'water-sport', 'dragon-dance', 'water-pulse', 'natural-gift', 'aqua-tail', 'earth-power', 'mud-bomb', 'captivate', 'round', 'scald', 'bulldoze', 'confide'], 'name': 'barboach', 'stats': {'hp': 50, 'attack': 48, 'defense': 43, 'special-attack': 46, 'special-defense': 41, 'speed': 60}, 'types': ['water', 'ground'], 'weight': 19, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'gray', 'shape': 'fish', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['water2'], 'names': {'ja-Hrkt': 'ドジョッチ', 'roomaji': 'Dojoach', 'ko': '미꾸리', 'zh-Hant': '泥泥鰍', 'fr': 'Barloche', 'de': 'Schmerbe', 'es': 'Barboach', 'it': 'Barboach', 'en': 'Barboach', 'ja': 'ドジョッチ', 'zh-Hans': '泥泥鰍'}, 'genera': {'ja-Hrkt': 'ひげうおポケモン', 'ko': '수염물고기포켓몬', 'zh-Hant': '鬚魚寶可夢', 'fr': 'Pokémon Barbillon', 'de': 'Barthaar', 'es': 'Pokémon Bigotudo', 'it': 'Pokémon Baffetti', 'en': 'Whiskers Pokémon', 'ja': 'ひげうおポケモン', 'zh-Hans': '须鱼宝可梦'}}
	public class SpecieBarboach : PokemonSpecie
	{
#nullable enable
		private static SpecieBarboach? _instance = null;
#nullable restore
        public static SpecieBarboach Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBarboach();
                }
                return _instance;
            }
        }

		public SpecieBarboach() : base(
			"Barboach",
			50, // HPs
			48, 43, // Attack & Defense
			46, 41, // Special Attack & Defense
			60			
		) {}
	}


	//Barboach Pokemon Class
	public class Barboach : Pokemon
	{

		public Barboach(string nickname, int level) : base(
			339,
			SpecieBarboach.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Ground.Instance			
		) {}

		public Barboach() : base(
			339,
			SpecieBarboach.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
	}
}