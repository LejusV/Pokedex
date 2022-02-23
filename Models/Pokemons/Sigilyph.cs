using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sigilyph Specie to store common natural stats of every {'abilities': ['wonder-skin', 'magic-guard', 'tinted-lens'], 'base_experience': 172, 'height': 14, 'id': 561, 'moves': ['gust', 'whirlwind', 'fly', 'ice-beam', 'psybeam', 'hyper-beam', 'solar-beam', 'thunder-wave', 'toxic', 'psychic', 'hypnosis', 'double-team', 'light-screen', 'reflect', 'mirror-move', 'dream-eater', 'sky-attack', 'flash', 'psywave', 'rest', 'substitute', 'thief', 'snore', 'protect', 'icy-wind', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'psych-up', 'ancient-power', 'shadow-ball', 'future-sight', 'heat-wave', 'facade', 'trick', 'magic-coat', 'skill-swap', 'secret-power', 'air-cutter', 'cosmic-power', 'signal-beam', 'aerial-ace', 'calm-mind', 'shock-wave', 'roost', 'gravity', 'miracle-eye', 'pluck', 'tailwind', 'psycho-shift', 'dark-pulse', 'air-slash', 'energy-ball', 'zen-headbutt', 'flash-cannon', 'trick-room', 'charge-beam', 'psyshock', 'telekinesis', 'magic-room', 'smack-down', 'synchronoise', 'round', 'stored-power', 'confide', 'dazzling-gleam'], 'name': 'sigilyph', 'stats': {'hp': 72, 'attack': 58, 'defense': 80, 'special-attack': 103, 'special-defense': 80, 'speed': 97}, 'types': ['psychic', 'flying'], 'weight': 140, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'black', 'shape': 'wings', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'シンボラー', 'ko': '심보러', 'zh-Hant': '象徵鳥', 'fr': 'Cryptéro', 'de': 'Symvolara', 'es': 'Sigilyph', 'it': 'Sigilyph', 'en': 'Sigilyph', 'ja': 'シンボラー', 'zh-Hans': '象征鸟'}, 'genera': {'ja-Hrkt': 'とりもどきポケモン', 'ko': '흡사새포켓몬', 'zh-Hant': '似鳥寶可夢', 'fr': 'Pokémon Similoiseau', 'de': 'Vogelgleich', 'es': 'Pokémon Pseudopájaro', 'it': 'Pokémon Pseuduccello', 'en': 'Avianoid Pokémon', 'ja': 'とりもどきポケモン', 'zh-Hans': '似鸟宝可梦'}}
	public class SpecieSigilyph : PokemonSpecie
	{
#nullable enable
		private static SpecieSigilyph? _instance = null;
#nullable restore
        public static SpecieSigilyph Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSigilyph();
                }
                return _instance;
            }
        }

		public SpecieSigilyph() : base(
			"Sigilyph",
			72, // HPs
			58, 80, // Attack & Defense
			103, 80, // Special Attack & Defense
			97			
		) {}
	}


	//Sigilyph Pokemon Class
	public class Sigilyph : Pokemon
	{

		public Sigilyph(string nickname, int level) : base(
			561,
			SpecieSigilyph.Instance, // Pokemon Specie
			nickname, level,
			Psychic.Instance, Flying.Instance			
		) {}

		public Sigilyph() : base(
			561,
			SpecieSigilyph.Instance, // Pokemon Specie
			Psychic.Instance, Flying.Instance			
		) {}
	}
}