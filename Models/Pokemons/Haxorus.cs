using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Haxorus Specie to store common natural stats of every {'abilities': ['rivalry', 'mold-breaker', 'unnerve'], 'base_experience': 243, 'height': 18, 'id': 612, 'moves': ['scratch', 'guillotine', 'swords-dance', 'cut', 'leer', 'roar', 'surf', 'hyper-beam', 'low-kick', 'strength', 'dragon-rage', 'earthquake', 'dig', 'toxic', 'double-team', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'scary-face', 'outrage', 'false-swipe', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'taunt', 'superpower', 'brick-break', 'endeavor', 'secret-power', 'rock-tomb', 'aerial-ace', 'dragon-claw', 'dragon-dance', 'shock-wave', 'payback', 'assurance', 'fling', 'poison-jab', 'aqua-tail', 'x-scissor', 'dragon-pulse', 'focus-blast', 'giga-impact', 'shadow-claw', 'draco-meteor', 'grass-knot', 'hone-claws', 'round', 'incinerate', 'bulldoze', 'dragon-tail', 'dual-chop', 'confide', 'brutal-swing'], 'name': 'haxorus', 'stats': {'hp': 76, 'attack': 147, 'defense': 90, 'special-attack': 60, 'special-defense': 70, 'speed': 97}, 'types': ['dragon'], 'weight': 1055, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'yellow', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'オノノクス', 'ko': '액스라이즈', 'zh-Hant': '雙斧戰龍', 'fr': 'Tranchodon', 'de': 'Maxax', 'es': 'Haxorus', 'it': 'Haxorus', 'en': 'Haxorus', 'ja': 'オノノクス', 'zh-Hans': '双斧战龙'}, 'genera': {'ja-Hrkt': 'あごオノポケモン', 'ko': '도끼턱포켓몬', 'zh-Hant': '顎斧寶可夢', 'fr': 'Pokémon Hachomenton', 'de': 'Beilkiefer', 'es': 'Pokémon Boca Hacha', 'it': 'Pokémon Mascellascia', 'en': 'Axe Jaw Pokémon', 'ja': 'あごオノポケモン', 'zh-Hans': '颚斧宝可梦'}}
	public class SpecieHaxorus : PokemonSpecie
	{
#nullable enable
		private static SpecieHaxorus? _instance = null;
#nullable restore
        public static SpecieHaxorus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHaxorus();
                }
                return _instance;
            }
        }

		public SpecieHaxorus() : base(
			"Haxorus",
			76, // HPs
			147, 90, // Attack & Defense
			60, 70, // Special Attack & Defense
			97			
		) {}
	}


	//Haxorus Pokemon Class
	public class Haxorus : Pokemon
	{

		public Haxorus(string nickname, int level) : base(
			612,
			SpecieHaxorus.Instance, // Pokemon Specie
			nickname, level,
			Dragon.Instance			
		) {}

		public Haxorus() : base(
			612,
			SpecieHaxorus.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
	}
}