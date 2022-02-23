using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Stoutland Specie to store common natural stats of every {'abilities': ['intimidate', 'sand-rush', 'scrappy'], 'base_experience': 225, 'height': 12, 'id': 508, 'moves': ['tackle', 'take-down', 'leer', 'bite', 'roar', 'surf', 'hyper-beam', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'double-team', 'rest', 'substitute', 'snore', 'reversal', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'shadow-ball', 'rock-smash', 'uproar', 'facade', 'helping-hand', 'superpower', 'secret-power', 'hyper-voice', 'odor-sleuth', 'rock-tomb', 'aerial-ace', 'covet', 'shock-wave', 'payback', 'last-resort', 'giga-impact', 'thunder-fang', 'ice-fang', 'fire-fang', 'iron-head', 'after-you', 'round', 'retaliate', 'work-up', 'wild-charge', 'snarl', 'play-rough', 'confide'], 'name': 'stoutland', 'stats': {'hp': 85, 'attack': 110, 'defense': 90, 'special-attack': 45, 'special-defense': 90, 'speed': 80}, 'types': ['normal'], 'weight': 610, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'gray', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ムーランド', 'ko': '바랜드', 'zh-Hant': '長毛狗', 'fr': 'Mastouffe', 'de': 'Bissbark', 'es': 'Stoutland', 'it': 'Stoutland', 'en': 'Stoutland', 'ja': 'ムーランド', 'zh-Hans': '长毛狗'}, 'genera': {'ja-Hrkt': 'かんだいポケモン', 'ko': '관대포켓몬', 'zh-Hant': '寬大寶可夢', 'fr': 'Pokémon Magnanime', 'de': 'Großmut', 'es': 'Pokémon Magnánimo', 'it': 'Pokémon Generosità', 'en': 'Big-Hearted Pokémon', 'ja': 'かんだいポケモン', 'zh-Hans': '宽大宝可梦'}}
	public class SpecieStoutland : PokemonSpecie
	{
#nullable enable
		private static SpecieStoutland? _instance = null;
#nullable restore
        public static SpecieStoutland Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStoutland();
                }
                return _instance;
            }
        }

		public SpecieStoutland() : base(
			"Stoutland",
			85, // HPs
			110, 90, // Attack & Defense
			45, 90, // Special Attack & Defense
			80			
		) {}
	}


	//Stoutland Pokemon Class
	public class Stoutland : Pokemon
	{

		public Stoutland(string nickname, int level) : base(
			508,
			SpecieStoutland.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Stoutland() : base(
			508,
			SpecieStoutland.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}