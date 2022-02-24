using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sawsbuck Specie to store common natural stats of every {'abilities': ['chlorophyll', 'sap-sipper', 'serene-grace'], 'base_experience': 166, 'height': 19, 'id': 586, 'moves': ['swords-dance', 'cut', 'double-kick', 'jump-kick', 'sand-attack', 'tackle', 'take-down', 'double-edge', 'growl', 'hyper-beam', 'leech-seed', 'solar-beam', 'thunder-wave', 'toxic', 'double-team', 'light-screen', 'flash', 'rest', 'substitute', 'snore', 'protect', 'feint-attack', 'giga-drain', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'megahorn', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'facade', 'nature-power', 'secret-power', 'camouflage', 'aromatherapy', 'bounce', 'last-resort', 'worry-seed', 'seed-bomb', 'energy-ball', 'giga-impact', 'grass-knot', 'round', 'echoed-voice', 'retaliate', 'work-up', 'wild-charge', 'horn-leech', 'confide'], 'name': 'sawsbuck', 'stats': {'hp': 80, 'attack': 100, 'defense': 70, 'special-attack': 60, 'special-defense': 70, 'speed': 95}, 'types': ['normal', 'grass'], 'weight': 925, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'メブキジカ', 'ko': '바라철록', 'zh-Hant': '萌芽鹿', 'fr': 'Haydaim', 'de': 'Kronjuwild', 'es': 'Sawsbuck', 'it': 'Sawsbuck', 'en': 'Sawsbuck', 'ja': 'メブキジカ', 'zh-Hans': '萌芽鹿'}, 'genera': {'ja-Hrkt': 'きせつポケモン', 'ko': '계절포켓몬', 'zh-Hant': '季節寶可夢', 'fr': 'Pokémon Saison', 'de': 'Jahreszeit', 'es': 'Pokémon Estacional', 'it': 'Pokémon Stagione', 'en': 'Season Pokémon', 'ja': 'きせつポケモン', 'zh-Hans': '季节宝可梦'}}
	public class SpecieSawsbuck : PokemonSpecie
	{
#nullable enable
		private static SpecieSawsbuck? _instance = null;
#nullable restore
        public static SpecieSawsbuck Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSawsbuck();
                }
                return _instance;
            }
        }

		public SpecieSawsbuck() : base(
			"Sawsbuck",
			80, // HPs
			100, 70, // Attack & Defense
			60, 70, // Special Attack & Defense
			95			
		) {}
	}


	//Sawsbuck Pokemon Class
	public class Sawsbuck : Pokemon
	{

		public Sawsbuck(string nickname, int level)
		: base(
				586,
				SpecieSawsbuck.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sawsbuck() : base(
			586,
			SpecieSawsbuck.Instance, // Pokemon Specie
			Normal.Instance, Grass.Instance			
		) {}
	}
}