using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Herdier Specie to store common natural stats of every {'abilities': ['intimidate', 'sand-rush', 'scrappy'], 'base_experience': 130, 'height': 9, 'id': 507, 'moves': ['tackle', 'take-down', 'leer', 'bite', 'roar', 'surf', 'strength', 'thunderbolt', 'thunder-wave', 'dig', 'toxic', 'double-team', 'rest', 'substitute', 'snore', 'reversal', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'shadow-ball', 'rock-smash', 'uproar', 'facade', 'helping-hand', 'secret-power', 'hyper-voice', 'odor-sleuth', 'rock-tomb', 'aerial-ace', 'covet', 'shock-wave', 'payback', 'last-resort', 'giga-impact', 'after-you', 'round', 'retaliate', 'work-up', 'wild-charge', 'snarl', 'play-rough', 'confide'], 'name': 'herdier', 'stats': {'hp': 65, 'attack': 80, 'defense': 65, 'special-attack': 35, 'special-defense': 65, 'speed': 60}, 'types': ['normal'], 'weight': 147, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'gray', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ハーデリア', 'ko': '하데리어', 'zh-Hant': '哈約克', 'fr': 'Ponchien', 'de': 'Terribark', 'es': 'Herdier', 'it': 'Herdier', 'en': 'Herdier', 'ja': 'ハーデリア', 'zh-Hans': '哈约克'}, 'genera': {'ja-Hrkt': 'ちゅうけんポケモン', 'ko': '충견포켓몬', 'zh-Hant': '忠犬寶可夢', 'fr': 'Pokémon Chien Fidèle', 'de': 'Treuhund', 'es': 'Pokémon Leal', 'it': 'Pokémon Fedeltà', 'en': 'Loyal Dog Pokémon', 'ja': 'ちゅうけんポケモン', 'zh-Hans': '忠犬宝可梦'}}
	public class SpecieHerdier : PokemonSpecie
	{
#nullable enable
		private static SpecieHerdier? _instance = null;
#nullable restore
        public static SpecieHerdier Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHerdier();
                }
                return _instance;
            }
        }

		public SpecieHerdier() : base(
			"Herdier",
			65, // HPs
			80, 65, // Attack & Defense
			35, 65, // Special Attack & Defense
			60			
		) {}
	}


	//Herdier Pokemon Class
	public class Herdier : Pokemon
	{

		public Herdier(string nickname, int level)
		: base(
				507,
				SpecieHerdier.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Herdier() : base(
			507,
			SpecieHerdier.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}