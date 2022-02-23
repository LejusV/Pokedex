using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Fraxure Specie to store common natural stats of every {'abilities': ['rivalry', 'mold-breaker', 'unnerve'], 'base_experience': 144, 'height': 10, 'id': 611, 'moves': ['scratch', 'guillotine', 'swords-dance', 'cut', 'leer', 'roar', 'low-kick', 'strength', 'dragon-rage', 'dig', 'toxic', 'double-team', 'rest', 'slash', 'substitute', 'snore', 'protect', 'scary-face', 'outrage', 'false-swipe', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'taunt', 'superpower', 'endeavor', 'secret-power', 'rock-tomb', 'aerial-ace', 'dragon-claw', 'dragon-dance', 'shock-wave', 'payback', 'assurance', 'fling', 'poison-jab', 'aqua-tail', 'x-scissor', 'dragon-pulse', 'giga-impact', 'shadow-claw', 'draco-meteor', 'hone-claws', 'round', 'incinerate', 'dragon-tail', 'dual-chop', 'confide'], 'name': 'fraxure', 'stats': {'hp': 66, 'attack': 117, 'defense': 70, 'special-attack': 40, 'special-defense': 50, 'speed': 67}, 'types': ['dragon'], 'weight': 360, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 60, 'color': 'green', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'オノンド', 'ko': '액슨도', 'zh-Hant': '斧牙龍', 'fr': 'Incisache', 'de': 'Sharfax', 'es': 'Fraxure', 'it': 'Fraxure', 'en': 'Fraxure', 'ja': 'オノンド', 'zh-Hans': '斧牙龙'}, 'genera': {'ja-Hrkt': 'あごオノポケモン', 'ko': '도끼턱포켓몬', 'zh-Hant': '顎斧寶可夢', 'fr': 'Pokémon Hachomenton', 'de': 'Beilkiefer', 'es': 'Pokémon Boca Hacha', 'it': 'Pokémon Mascellascia', 'en': 'Axe Jaw Pokémon', 'ja': 'あごオノポケモン', 'zh-Hans': '颚斧宝可梦'}}
	public class SpecieFraxure : PokemonSpecie
	{
#nullable enable
		private static SpecieFraxure? _instance = null;
#nullable restore
        public static SpecieFraxure Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFraxure();
                }
                return _instance;
            }
        }

		public SpecieFraxure() : base(
			"Fraxure",
			66, // HPs
			117, 70, // Attack & Defense
			40, 50, // Special Attack & Defense
			67			
		) {}
	}


	//Fraxure Pokemon Class
	public class Fraxure : Pokemon
	{

		public Fraxure(string nickname, int level) : base(
			611,
			SpecieFraxure.Instance, // Pokemon Specie
			nickname, level,
			Dragon.Instance			
		) {}

		public Fraxure() : base(
			611,
			SpecieFraxure.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
	}
}