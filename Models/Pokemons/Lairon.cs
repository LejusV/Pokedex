using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lairon Specie to store common natural stats of every {'abilities': ['sturdy', 'rock-head', 'heavy-metal'], 'base_experience': 151, 'height': 9, 'id': 305, 'moves': ['cut', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'roar', 'strength', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'harden', 'defense-curl', 'rest', 'rock-slide', 'substitute', 'snore', 'spite', 'protect', 'mud-slap', 'sandstorm', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'metal-claw', 'hidden-power', 'rain-dance', 'sunny-day', 'ancient-power', 'rock-smash', 'uproar', 'facade', 'superpower', 'endeavor', 'secret-power', 'rock-tomb', 'metal-sound', 'aerial-ace', 'iron-defense', 'shock-wave', 'water-pulse', 'natural-gift', 'metal-burst', 'magnet-rise', 'rock-polish', 'earth-power', 'shadow-claw', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'hone-claws', 'autotomize', 'heavy-slam', 'round', 'bulldoze', 'confide'], 'name': 'lairon', 'stats': {'hp': 60, 'attack': 90, 'defense': 140, 'special-attack': 50, 'special-defense': 50, 'speed': 40}, 'types': ['steel', 'rock'], 'weight': 1200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': 4, 'capture_rate': 90, 'color': 'gray', 'shape': 'quadruped', 'habitat': 'mountain', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'コドラ', 'roomaji': 'Kodora', 'ko': '갱도라', 'zh-Hant': '可多拉', 'fr': 'Galegon', 'de': 'Stollrak', 'es': 'Lairon', 'it': 'Lairon', 'en': 'Lairon', 'ja': 'コドラ', 'zh-Hans': '可多拉'}, 'genera': {'ja-Hrkt': 'てつヨロイポケモン', 'ko': '철갑옷포켓몬', 'zh-Hant': '鐵鎧寶可夢', 'fr': 'Pokémon Armurfer', 'de': 'Eisenpanzer', 'es': 'Pokémon Cor. Férrea', 'it': 'Pokémon Corazza', 'en': 'Iron Armor Pokémon', 'ja': 'てつヨロイポケモン', 'zh-Hans': '铁铠宝可梦'}}
	public class SpecieLairon : PokemonSpecie
	{
#nullable enable
		private static SpecieLairon? _instance = null;
#nullable restore
        public static SpecieLairon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLairon();
                }
                return _instance;
            }
        }

		public SpecieLairon() : base(
			"Lairon",
			60, // HPs
			90, 140, // Attack & Defense
			50, 50, // Special Attack & Defense
			40			
		) {}
	}


	//Lairon Pokemon Class
	public class Lairon : Pokemon
	{

		public Lairon(string nickname, int level)
		: base(
				305,
				SpecieLairon.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lairon(int level)
		: base(
				305,
				SpecieLairon.Instance, // Pokemon Specie
				"Lairon", level,
				Steel.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lairon() : base(
			305,
			SpecieLairon.Instance, // Pokemon Specie
			Steel.Instance, Rock.Instance			
		) {}
	}
}