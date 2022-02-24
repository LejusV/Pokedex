using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Nincada Specie to store common natural stats of every {'abilities': ['compound-eyes', 'run-away'], 'base_experience': 53, 'height': 5, 'id': 290, 'moves': ['scratch', 'cut', 'gust', 'sand-attack', 'double-edge', 'absorb', 'solar-beam', 'string-shot', 'dig', 'toxic', 'mimic', 'double-team', 'harden', 'bide', 'leech-life', 'flash', 'fury-swipes', 'rest', 'substitute', 'mind-reader', 'snore', 'spite', 'protect', 'feint-attack', 'mud-slap', 'sandstorm', 'giga-drain', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'sleep-talk', 'return', 'frustration', 'metal-claw', 'hidden-power', 'sunny-day', 'shadow-ball', 'facade', 'secret-power', 'silver-wind', 'aerial-ace', 'natural-gift', 'night-slash', 'x-scissor', 'bug-buzz', 'bug-bite', 'hone-claws', 'round', 'final-gambit', 'struggle-bug', 'confide'], 'name': 'nincada', 'stats': {'hp': 31, 'attack': 45, 'defense': 90, 'special-attack': 30, 'special-defense': 30, 'speed': 40}, 'types': ['bug', 'ground'], 'weight': 55, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'gray', 'shape': 'armor', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ツチニン', 'roomaji': 'Tutinin', 'ko': '토중몬', 'zh-Hant': '土居忍士', 'fr': 'Ningale', 'de': 'Nincada', 'es': 'Nincada', 'it': 'Nincada', 'en': 'Nincada', 'ja': 'ツチニン', 'zh-Hans': '土居忍士'}, 'genera': {'ja-Hrkt': 'したづみポケモン', 'ko': '신참포켓몬', 'zh-Hant': '入門寶可夢', 'fr': 'Pokémon Apprenti', 'de': 'Vorbereiter', 'es': 'Pokémon Aprendiz', 'it': 'Pokémon Novizio', 'en': 'Trainee Pokémon', 'ja': 'したづみポケモン', 'zh-Hans': '入门宝可梦'}}
	public class SpecieNincada : PokemonSpecie
	{
#nullable enable
		private static SpecieNincada? _instance = null;
#nullable restore
        public static SpecieNincada Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNincada();
                }
                return _instance;
            }
        }

		public SpecieNincada() : base(
			"Nincada",
			31, // HPs
			45, 90, // Attack & Defense
			30, 30, // Special Attack & Defense
			40			
		) {}
	}


	//Nincada Pokemon Class
	public class Nincada : Pokemon
	{

		public Nincada(string nickname, int level)
		: base(
				290,
				SpecieNincada.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Nincada() : base(
			290,
			SpecieNincada.Instance, // Pokemon Specie
			Bug.Instance, Ground.Instance			
		) {}
	}
}