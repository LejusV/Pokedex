using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lunala Specie to store common natural stats of every {'abilities': ['shadow-shield'], 'base_experience': 306, 'height': 40, 'id': 792, 'moves': ['fly', 'roar', 'ice-beam', 'blizzard', 'hyper-beam', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'confusion', 'psychic', 'hypnosis', 'teleport', 'night-shade', 'double-team', 'confuse-ray', 'light-screen', 'reflect', 'dream-eater', 'rest', 'substitute', 'protect', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'moonlight', 'hidden-power', 'sunny-day', 'psych-up', 'shadow-ball', 'will-o-wisp', 'facade', 'magic-coat', 'cosmic-power', 'aerial-ace', 'calm-mind', 'roost', 'air-slash', 'focus-blast', 'giga-impact', 'shadow-claw', 'trick-room', 'charge-beam', 'wide-guard', 'psyshock', 'round', 'sky-drop', 'acrobatics', 'work-up', 'night-daze', 'phantom-force', 'moonblast', 'confide', 'dazzling-gleam', 'moongeist-beam'], 'name': 'lunala', 'stats': {'hp': 137, 'attack': 113, 'defense': 89, 'special-attack': 137, 'special-defense': 107, 'speed': 97}, 'types': ['psychic', 'ghost'], 'weight': 1200, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'purple', 'shape': 'wings', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ルナアーラ', 'ko': '루나아라', 'zh-Hant': '露奈雅拉', 'fr': 'Lunala', 'de': 'Lunala', 'es': 'Lunala', 'it': 'Lunala', 'en': 'Lunala', 'ja': 'ルナアーラ', 'zh-Hans': '露奈雅拉'}, 'genera': {'ja-Hrkt': 'がちりんポケモン', 'ko': '월륜포켓몬', 'zh-Hant': '月輪寶可夢', 'fr': 'Pokémon Halo Lunaire', 'de': 'Mondscheibe', 'es': 'Pokémon Corona Lunar', 'it': 'Pokémon Lunare', 'en': 'Moone Pokémon', 'ja': 'がちりんポケモン', 'zh-Hans': '月轮宝可梦'}}
	public class SpecieLunala : PokemonSpecie
	{
#nullable enable
		private static SpecieLunala? _instance = null;
#nullable restore
        public static SpecieLunala Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLunala();
                }
                return _instance;
            }
        }

		public SpecieLunala() : base(
			"Lunala",
			137, // HPs
			113, 89, // Attack & Defense
			137, 107, // Special Attack & Defense
			97			
		) {}
	}


	//Lunala Pokemon Class
	public class Lunala : Pokemon
	{

		public Lunala(string nickname, int level) : base(
			792,
			SpecieLunala.Instance, // Pokemon Specie
			nickname, level,
			Psychic.Instance, Ghost.Instance			
		) {}

		public Lunala() : base(
			792,
			SpecieLunala.Instance, // Pokemon Specie
			Psychic.Instance, Ghost.Instance			
		) {}
	}
}