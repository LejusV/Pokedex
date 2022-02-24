using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shelgon Specie to store common natural stats of every {'abilities': ['rock-head', 'overcoat'], 'base_experience': 147, 'height': 11, 'id': 372, 'moves': ['cut', 'headbutt', 'body-slam', 'double-edge', 'leer', 'bite', 'roar', 'ember', 'flamethrower', 'strength', 'toxic', 'rage', 'mimic', 'double-team', 'defense-curl', 'focus-energy', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'scary-face', 'mud-slap', 'outrage', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'crunch', 'rock-smash', 'facade', 'brick-break', 'secret-power', 'hyper-voice', 'rock-tomb', 'aerial-ace', 'iron-defense', 'dragon-claw', 'natural-gift', 'dragon-pulse', 'shadow-claw', 'zen-headbutt', 'draco-meteor', 'captivate', 'hone-claws', 'round', 'incinerate', 'confide'], 'name': 'shelgon', 'stats': {'hp': 65, 'attack': 95, 'defense': 100, 'special-attack': 60, 'special-defense': 50, 'speed': 50}, 'types': ['dragon'], 'weight': 1105, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'white', 'shape': 'quadruped', 'habitat': 'rough-terrain', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['dragon'], 'names': {'de': 'Draschel', 'ja-Hrkt': 'コモルー', 'roomaji': 'Komoruu', 'ko': '쉘곤', 'zh-Hant': '甲殼龍', 'fr': 'Drackhaus', 'es': 'Shelgon', 'it': 'Shelgon', 'en': 'Shelgon', 'ja': 'コモルー', 'zh-Hans': '甲壳龙'}, 'genera': {'de': 'Durchsteher', 'ja-Hrkt': 'にんたいポケモン', 'ko': '인내포켓몬', 'zh-Hant': '耐力寶可夢', 'fr': 'Pokémon Endurant', 'es': 'Pokémon Resistencia', 'it': 'Pokémon Resistenza', 'en': 'Endurance Pokémon', 'ja': 'にんたいポケモン', 'zh-Hans': '耐力宝可梦'}}
	public class SpecieShelgon : PokemonSpecie
	{
#nullable enable
		private static SpecieShelgon? _instance = null;
#nullable restore
        public static SpecieShelgon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShelgon();
                }
                return _instance;
            }
        }

		public SpecieShelgon() : base(
			"Shelgon",
			65, // HPs
			95, 100, // Attack & Defense
			60, 50, // Special Attack & Defense
			50			
		) {}
	}


	//Shelgon Pokemon Class
	public class Shelgon : Pokemon
	{

		public Shelgon(string nickname, int level)
		: base(
				372,
				SpecieShelgon.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Shelgon(int level)
		: base(
				372,
				SpecieShelgon.Instance, // Pokemon Specie
				"Shelgon", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Shelgon() : base(
			372,
			SpecieShelgon.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
	}
}