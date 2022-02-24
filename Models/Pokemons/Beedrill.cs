using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Beedrill Specie to store common natural stats of every {'abilities': ['swarm', 'sniper'], 'base_experience': 178, 'height': 10, 'id': 15, 'moves': ['swords-dance', 'cut', 'fury-attack', 'take-down', 'double-edge', 'twineedle', 'pin-missile', 'hyper-beam', 'mega-drain', 'solar-beam', 'string-shot', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'reflect', 'focus-energy', 'bide', 'swift', 'skull-bash', 'flash', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'sweet-scent', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'brick-break', 'knock-off', 'endeavor', 'secret-power', 'air-cutter', 'silver-wind', 'aerial-ace', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'payback', 'assurance', 'toxic-spikes', 'poison-jab', 'x-scissor', 'giga-impact', 'defog', 'captivate', 'bug-bite', 'ominous-wind', 'venoshock', 'round', 'acrobatics', 'struggle-bug', 'electroweb', 'drill-run', 'fell-stinger', 'confide', 'infestation', 'brutal-swing'], 'name': 'beedrill', 'stats': {'hp': 65, 'attack': 90, 'defense': 40, 'special-attack': 45, 'special-defense': 80, 'speed': 75}, 'types': ['bug', 'poison'], 'weight': 295, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'yellow', 'shape': 'bug-wings', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'スピアー', 'roomaji': 'Spear', 'ko': '독침붕', 'zh-Hant': '大針蜂', 'fr': 'Dardargnan', 'de': 'Bibor', 'es': 'Beedrill', 'it': 'Beedrill', 'en': 'Beedrill', 'ja': 'スピアー', 'zh-Hans': '大针蜂'}, 'genera': {'ja-Hrkt': 'どくばちポケモン', 'ko': '독벌포켓몬', 'zh-Hant': '毒蜂寶可夢', 'fr': 'Pokémon Guêpoison', 'de': 'Giftbiene', 'es': 'Pokémon Abeja Veneno', 'it': 'Pokémon Velenape', 'en': 'Poison Bee Pokémon', 'ja': 'どくばちポケモン', 'zh-Hans': '毒蜂宝可梦'}}
	public class SpecieBeedrill : PokemonSpecie
	{
#nullable enable
		private static SpecieBeedrill? _instance = null;
#nullable restore
        public static SpecieBeedrill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBeedrill();
                }
                return _instance;
            }
        }

		public SpecieBeedrill() : base(
			"Beedrill",
			65, // HPs
			90, 40, // Attack & Defense
			45, 80, // Special Attack & Defense
			75			
		) {}
	}


	//Beedrill Pokemon Class
	public class Beedrill : Pokemon
	{

		public Beedrill(string nickname, int level)
		: base(
				15,
				SpecieBeedrill.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Beedrill() : base(
			15,
			SpecieBeedrill.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
	}
}