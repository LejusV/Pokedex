using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Claydol Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 175, 'height': 15, 'id': 344, 'moves': ['headbutt', 'double-edge', 'ice-beam', 'psybeam', 'hyper-beam', 'strength', 'solar-beam', 'earthquake', 'dig', 'toxic', 'confusion', 'psychic', 'teleport', 'mimic', 'double-team', 'harden', 'light-screen', 'reflect', 'self-destruct', 'dream-eater', 'flash', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'sandstorm', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'rapid-spin', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'shadow-ball', 'rock-smash', 'facade', 'trick', 'magic-coat', 'recycle', 'skill-swap', 'imprison', 'secret-power', 'rock-tomb', 'cosmic-power', 'signal-beam', 'extrasensory', 'calm-mind', 'gravity', 'gyro-ball', 'natural-gift', 'heal-block', 'power-trick', 'rock-polish', 'earth-power', 'giga-impact', 'zen-headbutt', 'trick-room', 'stone-edge', 'stealth-rock', 'grass-knot', 'charge-beam', 'guard-split', 'power-split', 'wonder-room', 'psyshock', 'telekinesis', 'smack-down', 'round', 'ally-switch', 'bulldoze', 'drill-run', 'confide', 'dazzling-gleam'], 'name': 'claydol', 'stats': {'hp': 60, 'attack': 70, 'defense': 105, 'special-attack': 70, 'special-defense': 120, 'speed': 75}, 'types': ['ground', 'psychic'], 'weight': 1080, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 90, 'color': 'black', 'shape': 'arms', 'habitat': 'rough-terrain', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ネンドール', 'roomaji': 'Nendoll', 'ko': '점토도리', 'zh-Hant': '念力土偶', 'fr': 'Kaorine', 'de': 'Lepumentas', 'es': 'Claydol', 'it': 'Claydol', 'en': 'Claydol', 'ja': 'ネンドール', 'zh-Hans': '念力土偶'}, 'genera': {'ja-Hrkt': 'どぐうポケモン', 'ko': '토우포켓몬', 'zh-Hant': '泥偶寶可夢', 'fr': 'Pokémon Poupargile', 'de': 'Lehmpuppe', 'es': 'Pokémon Muñeca Barro', 'it': 'Pokémon Argilla', 'en': 'Clay Doll Pokémon', 'ja': 'どぐうポケモン', 'zh-Hans': '泥偶宝可梦'}}
	public class SpecieClaydol : PokemonSpecie
	{
#nullable enable
		private static SpecieClaydol? _instance = null;
#nullable restore
        public static SpecieClaydol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieClaydol();
                }
                return _instance;
            }
        }

		public SpecieClaydol() : base(
			"Claydol",
			60, // HPs
			70, 105, // Attack & Defense
			70, 120, // Special Attack & Defense
			75			
		) {}
	}


	//Claydol Pokemon Class
	public class Claydol : Pokemon
	{

		public Claydol(string nickname, int level)
		: base(
				344,
				SpecieClaydol.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Claydol(int level)
		: base(
				344,
				SpecieClaydol.Instance, // Pokemon Specie
				"Claydol", level,
				Ground.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Claydol() : base(
			344,
			SpecieClaydol.Instance, // Pokemon Specie
			Ground.Instance, Psychic.Instance			
		) {}
	}
}