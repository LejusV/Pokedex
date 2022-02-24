using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Aerodactyl Specie to store common natural stats of every {'abilities': ['rock-head', 'pressure', 'unnerve'], 'base_experience': 180, 'height': 18, 'id': 142, 'moves': ['razor-wind', 'wing-attack', 'whirlwind', 'fly', 'headbutt', 'take-down', 'double-edge', 'bite', 'roar', 'supersonic', 'flamethrower', 'hyper-beam', 'strength', 'dragon-rage', 'earthquake', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'fire-blast', 'swift', 'sky-attack', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'protect', 'scary-face', 'foresight', 'detect', 'sandstorm', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'pursuit', 'iron-tail', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'crunch', 'ancient-power', 'rock-smash', 'heat-wave', 'torment', 'facade', 'taunt', 'secret-power', 'air-cutter', 'rock-tomb', 'aerial-ace', 'dragon-claw', 'roost', 'natural-gift', 'tailwind', 'payback', 'assurance', 'rock-polish', 'aqua-tail', 'dragon-pulse', 'earth-power', 'giga-impact', 'thunder-fang', 'ice-fang', 'fire-fang', 'defog', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'ominous-wind', 'hone-claws', 'wide-guard', 'smack-down', 'round', 'sky-drop', 'incinerate', 'bulldoze', 'confide', 'brutal-swing'], 'name': 'aerodactyl', 'stats': {'hp': 80, 'attack': 105, 'defense': 65, 'special-attack': 60, 'special-defense': 75, 'speed': 130}, 'types': ['rock', 'flying'], 'weight': 590, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': 1, 'capture_rate': 45, 'color': 'purple', 'shape': 'wings', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'プテラ', 'roomaji': 'Ptera', 'ko': '프테라', 'zh-Hant': '化石翼龍', 'fr': 'Ptéra', 'de': 'Aerodactyl', 'es': 'Aerodactyl', 'it': 'Aerodactyl', 'en': 'Aerodactyl', 'ja': 'プテラ', 'zh-Hans': '化石翼龙'}, 'genera': {'ja-Hrkt': 'かせきポケモン', 'ko': '화석포켓몬', 'zh-Hant': '化石寶可夢', 'fr': 'Pokémon Fossile', 'de': 'Fossil', 'es': 'Pokémon Fósil', 'it': 'Pokémon Fossile', 'en': 'Fossil Pokémon', 'ja': 'かせきポケモン', 'zh-Hans': '化石宝可梦'}}
	public class SpecieAerodactyl : PokemonSpecie
	{
#nullable enable
		private static SpecieAerodactyl? _instance = null;
#nullable restore
        public static SpecieAerodactyl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAerodactyl();
                }
                return _instance;
            }
        }

		public SpecieAerodactyl() : base(
			"Aerodactyl",
			80, // HPs
			105, 65, // Attack & Defense
			60, 75, // Special Attack & Defense
			130			
		) {}
	}


	//Aerodactyl Pokemon Class
	public class Aerodactyl : Pokemon
	{

		public Aerodactyl(string nickname, int level)
		: base(
				142,
				SpecieAerodactyl.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Aerodactyl() : base(
			142,
			SpecieAerodactyl.Instance, // Pokemon Specie
			Rock.Instance, Flying.Instance			
		) {}
	}
}