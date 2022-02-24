using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Baltoy Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 60, 'height': 5, 'id': 343, 'moves': ['headbutt', 'double-edge', 'ice-beam', 'psybeam', 'solar-beam', 'earthquake', 'dig', 'toxic', 'confusion', 'psychic', 'mimic', 'double-team', 'harden', 'light-screen', 'reflect', 'self-destruct', 'dream-eater', 'flash', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'sandstorm', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'rapid-spin', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'shadow-ball', 'facade', 'trick', 'magic-coat', 'recycle', 'skill-swap', 'imprison', 'secret-power', 'rock-tomb', 'cosmic-power', 'signal-beam', 'extrasensory', 'calm-mind', 'gravity', 'gyro-ball', 'natural-gift', 'heal-block', 'power-trick', 'rock-polish', 'earth-power', 'zen-headbutt', 'trick-room', 'stealth-rock', 'grass-knot', 'charge-beam', 'guard-split', 'power-split', 'wonder-room', 'psyshock', 'telekinesis', 'smack-down', 'round', 'ally-switch', 'bulldoze', 'drill-run', 'confide', 'dazzling-gleam'], 'name': 'baltoy', 'stats': {'hp': 40, 'attack': 40, 'defense': 55, 'special-attack': 40, 'special-defense': 70, 'speed': 55}, 'types': ['ground', 'psychic'], 'weight': 215, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 255, 'color': 'brown', 'shape': 'arms', 'habitat': 'rough-terrain', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ヤジロン', 'roomaji': 'Yajilon', 'ko': '오뚝군', 'zh-Hant': '天秤偶', 'fr': 'Balbuto', 'de': 'Puppance', 'es': 'Baltoy', 'it': 'Baltoy', 'en': 'Baltoy', 'ja': 'ヤジロン', 'zh-Hans': '天秤偶'}, 'genera': {'ja-Hrkt': 'どぐうポケモン', 'ko': '토우포켓몬', 'zh-Hant': '泥偶寶可夢', 'fr': 'Pokémon Poupargile', 'de': 'Lehmpuppe', 'es': 'Pokémon Muñeca Barro', 'it': 'Pokémon Argilla', 'en': 'Clay Doll Pokémon', 'ja': 'どぐうポケモン', 'zh-Hans': '泥偶宝可梦'}}
	public class SpecieBaltoy : PokemonSpecie
	{
#nullable enable
		private static SpecieBaltoy? _instance = null;
#nullable restore
        public static SpecieBaltoy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBaltoy();
                }
                return _instance;
            }
        }

		public SpecieBaltoy() : base(
			"Baltoy",
			40, // HPs
			40, 55, // Attack & Defense
			40, 70, // Special Attack & Defense
			55			
		) {}
	}


	//Baltoy Pokemon Class
	public class Baltoy : Pokemon
	{

		public Baltoy(string nickname, int level)
		: base(
				343,
				SpecieBaltoy.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Baltoy() : base(
			343,
			SpecieBaltoy.Instance, // Pokemon Specie
			Ground.Instance, Psychic.Instance			
		) {}
	}
}