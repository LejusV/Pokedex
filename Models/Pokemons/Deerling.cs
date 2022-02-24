using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Deerling Specie to store common natural stats of every {'abilities': ['chlorophyll', 'sap-sipper', 'serene-grace'], 'base_experience': 67, 'height': 6, 'id': 585, 'moves': ['double-kick', 'jump-kick', 'sand-attack', 'headbutt', 'tackle', 'take-down', 'double-edge', 'growl', 'leech-seed', 'solar-beam', 'thunder-wave', 'toxic', 'agility', 'double-team', 'light-screen', 'flash', 'rest', 'substitute', 'snore', 'protect', 'feint-attack', 'giga-drain', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'baton-pass', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'facade', 'nature-power', 'secret-power', 'camouflage', 'aromatherapy', 'fake-tears', 'odor-sleuth', 'grass-whistle', 'bounce', 'natural-gift', 'last-resort', 'worry-seed', 'seed-bomb', 'energy-ball', 'grass-knot', 'round', 'echoed-voice', 'retaliate', 'work-up', 'wild-charge', 'confide'], 'name': 'deerling', 'stats': {'hp': 60, 'attack': 60, 'defense': 50, 'special-attack': 40, 'special-defense': 50, 'speed': 75}, 'types': ['normal', 'grass'], 'weight': 195, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'pink', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'シキジカ', 'ko': '사철록', 'zh-Hant': '四季鹿', 'fr': 'Vivaldaim', 'de': 'Sesokitz', 'es': 'Deerling', 'it': 'Deerling', 'en': 'Deerling', 'ja': 'シキジカ', 'zh-Hans': '四季鹿'}, 'genera': {'ja-Hrkt': 'きせつポケモン', 'ko': '계절포켓몬', 'zh-Hant': '季節寶可夢', 'fr': 'Pokémon Saison', 'de': 'Jahreszeit', 'es': 'Pokémon Estacional', 'it': 'Pokémon Stagione', 'en': 'Season Pokémon', 'ja': 'きせつポケモン', 'zh-Hans': '季节宝可梦'}}
	public class SpecieDeerling : PokemonSpecie
	{
#nullable enable
		private static SpecieDeerling? _instance = null;
#nullable restore
        public static SpecieDeerling Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDeerling();
                }
                return _instance;
            }
        }

		public SpecieDeerling() : base(
			"Deerling",
			60, // HPs
			60, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			75			
		) {}
	}


	//Deerling Pokemon Class
	public class Deerling : Pokemon
	{

		public Deerling(string nickname, int level)
		: base(
				585,
				SpecieDeerling.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Deerling() : base(
			585,
			SpecieDeerling.Instance, // Pokemon Specie
			Normal.Instance, Grass.Instance			
		) {}
	}
}