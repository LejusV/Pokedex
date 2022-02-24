using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Arceus Specie to store common natural stats of every {'abilities': ['multitype'], 'base_experience': 324, 'height': 32, 'id': 493, 'moves': ['swords-dance', 'cut', 'fly', 'headbutt', 'roar', 'flamethrower', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'psychic', 'double-team', 'recover', 'light-screen', 'reflect', 'fire-blast', 'waterfall', 'swift', 'dream-eater', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'sludge-bomb', 'mud-slap', 'perish-song', 'icy-wind', 'outrage', 'sandstorm', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'sleep-talk', 'return', 'frustration', 'safeguard', 'iron-tail', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'extreme-speed', 'ancient-power', 'shadow-ball', 'future-sight', 'rock-smash', 'whirlpool', 'heat-wave', 'hail', 'will-o-wisp', 'facade', 'trick', 'magic-coat', 'recycle', 'brick-break', 'refresh', 'secret-power', 'dive', 'hyper-voice', 'overheat', 'rock-tomb', 'silver-wind', 'cosmic-power', 'signal-beam', 'bullet-seed', 'aerial-ace', 'iron-defense', 'dragon-claw', 'calm-mind', 'shock-wave', 'water-pulse', 'gravity', 'brine', 'natural-gift', 'tailwind', 'payback', 'punishment', 'last-resort', 'poison-jab', 'dark-pulse', 'aqua-tail', 'x-scissor', 'dragon-pulse', 'focus-blast', 'energy-ball', 'earth-power', 'giga-impact', 'avalanche', 'shadow-claw', 'zen-headbutt', 'flash-cannon', 'rock-climb', 'defog', 'trick-room', 'draco-meteor', 'iron-head', 'stone-edge', 'stealth-rock', 'grass-knot', 'judgment', 'charge-beam', 'ominous-wind', 'hone-claws', 'psyshock', 'telekinesis', 'round', 'echoed-voice', 'incinerate', 'quash', 'retaliate', 'bulldoze', 'work-up', 'snarl', 'confide'], 'name': 'arceus', 'stats': {'hp': 120, 'attack': 120, 'defense': 120, 'special-attack': 120, 'special-defense': 120, 'speed': 120}, 'types': ['normal'], 'weight': 3200, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'white', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'アルセウス', 'roomaji': 'Arceus', 'ko': '아르세우스', 'zh-Hant': '阿爾宙斯', 'fr': 'Arceus', 'de': 'Arceus', 'es': 'Arceus', 'it': 'Arceus', 'en': 'Arceus', 'ja': 'アルセウス', 'zh-Hans': '阿尔宙斯'}, 'genera': {'ja-Hrkt': 'そうぞうポケモン', 'ko': '창조포켓몬', 'zh-Hant': '創造寶可夢', 'fr': 'Pokémon Alpha', 'de': 'Alpha', 'es': 'Pokémon Alfa', 'it': 'Pokémon Primevo', 'en': 'Alpha Pokémon', 'ja': 'そうぞうポケモン', 'zh-Hans': '创造宝可梦'}}
	public class SpecieArceus : PokemonSpecie
	{
#nullable enable
		private static SpecieArceus? _instance = null;
#nullable restore
        public static SpecieArceus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArceus();
                }
                return _instance;
            }
        }

		public SpecieArceus() : base(
			"Arceus",
			120, // HPs
			120, 120, // Attack & Defense
			120, 120, // Special Attack & Defense
			120			
		) {}
	}


	//Arceus Pokemon Class
	public class Arceus : Pokemon
	{

		public Arceus(string nickname, int level)
		: base(
				493,
				SpecieArceus.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Arceus() : base(
			493,
			SpecieArceus.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}