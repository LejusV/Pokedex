using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dodrio Specie to store common natural stats of every {'abilities': ['run-away', 'early-bird', 'tangled-feet'], 'base_experience': 165, 'height': 18, 'id': 85, 'moves': ['swords-dance', 'whirlwind', 'fly', 'jump-kick', 'fury-attack', 'body-slam', 'take-down', 'thrash', 'double-edge', 'growl', 'hyper-beam', 'peck', 'drill-peck', 'toxic', 'agility', 'quick-attack', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'swift', 'skull-bash', 'sky-attack', 'rest', 'tri-attack', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'sunny-day', 'uproar', 'torment', 'facade', 'taunt', 'knock-off', 'endeavor', 'secret-power', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'acupressure', 'payback', 'giga-impact', 'captivate', 'double-hit', 'round', 'echoed-voice', 'work-up', 'confide'], 'name': 'dodrio', 'stats': {'hp': 60, 'attack': 110, 'defense': 70, 'special-attack': 60, 'special-defense': 60, 'speed': 110}, 'types': ['normal', 'flying'], 'weight': 852, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'brown', 'shape': 'legs', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ドードリオ', 'roomaji': 'Dodorio', 'ko': '두트리오', 'zh-Hant': '嘟嘟利', 'fr': 'Dodrio', 'de': 'Dodri', 'es': 'Dodrio', 'it': 'Dodrio', 'en': 'Dodrio', 'ja': 'ドードリオ', 'zh-Hans': '嘟嘟利'}, 'genera': {'ja-Hrkt': 'みつごどりポケモン', 'ko': '세쌍둥이새포켓몬', 'zh-Hant': '三頭鳥寶可夢', 'fr': 'Pokémon Trioiseau', 'de': 'Trivogel', 'es': 'Pokémon Ave Triple', 'it': 'Pokémon Triuccello', 'en': 'Triple Bird Pokémon', 'ja': 'みつごどりポケモン', 'zh-Hans': '三头鸟宝可梦'}}
	public class SpecieDodrio : PokemonSpecie
	{
#nullable enable
		private static SpecieDodrio? _instance = null;
#nullable restore
        public static SpecieDodrio Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDodrio();
                }
                return _instance;
            }
        }

		public SpecieDodrio() : base(
			"Dodrio",
			60, // HPs
			110, 70, // Attack & Defense
			60, 60, // Special Attack & Defense
			110			
		) {}
	}


	//Dodrio Pokemon Class
	public class Dodrio : Pokemon
	{

		public Dodrio(string nickname, int level) : base(
			85,
			SpecieDodrio.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance, Flying.Instance			
		) {}

		public Dodrio() : base(
			85,
			SpecieDodrio.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}