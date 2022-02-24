using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shedinja Specie to store common natural stats of every {'abilities': ['wonder-guard'], 'base_experience': 83, 'height': 8, 'id': 292, 'moves': ['scratch', 'cut', 'sand-attack', 'double-edge', 'hyper-beam', 'absorb', 'solar-beam', 'string-shot', 'dig', 'toxic', 'mimic', 'double-team', 'harden', 'confuse-ray', 'dream-eater', 'leech-life', 'flash', 'fury-swipes', 'rest', 'substitute', 'thief', 'mind-reader', 'nightmare', 'snore', 'spite', 'protect', 'mud-slap', 'sandstorm', 'giga-drain', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'shadow-ball', 'will-o-wisp', 'facade', 'trick', 'grudge', 'secret-power', 'aerial-ace', 'natural-gift', 'heal-block', 'sucker-punch', 'x-scissor', 'giga-impact', 'shadow-claw', 'shadow-sneak', 'bug-bite', 'hone-claws', 'telekinesis', 'round', 'struggle-bug', 'phantom-force', 'confide'], 'name': 'shedinja', 'stats': {'hp': 1, 'attack': 90, 'defense': 45, 'special-attack': 30, 'special-defense': 30, 'speed': 40}, 'types': ['bug', 'ghost'], 'weight': 12, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': -1, 'capture_rate': 45, 'color': 'brown', 'shape': 'blob', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ヌケニン', 'roomaji': 'Nukenin', 'ko': '껍질몬', 'zh-Hant': '脫殼忍者', 'fr': 'Munja', 'de': 'Ninjatom', 'es': 'Shedinja', 'it': 'Shedinja', 'en': 'Shedinja', 'ja': 'ヌケニン', 'zh-Hans': '脱壳忍者'}, 'genera': {'ja-Hrkt': 'ぬけがらポケモン', 'ko': '허물포켓몬', 'zh-Hant': '空殼寶可夢', 'fr': 'Pokémon Exuvie', 'de': 'Häutung', 'es': 'Pokémon Muda', 'it': 'Pokémon Cambiapelle', 'en': 'Shed Pokémon', 'ja': 'ぬけがらポケモン', 'zh-Hans': '空壳宝可梦'}}
	public class SpecieShedinja : PokemonSpecie
	{
#nullable enable
		private static SpecieShedinja? _instance = null;
#nullable restore
        public static SpecieShedinja Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShedinja();
                }
                return _instance;
            }
        }

		public SpecieShedinja() : base(
			"Shedinja",
			1, // HPs
			90, 45, // Attack & Defense
			30, 30, // Special Attack & Defense
			40			
		) {}
	}


	//Shedinja Pokemon Class
	public class Shedinja : Pokemon
	{

		public Shedinja(string nickname, int level)
		: base(
				292,
				SpecieShedinja.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Shedinja(int level)
		: base(
				292,
				SpecieShedinja.Instance, // Pokemon Specie
				"Shedinja", level,
				Bug.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Shedinja() : base(
			292,
			SpecieShedinja.Instance, // Pokemon Specie
			Bug.Instance, Ghost.Instance			
		) {}
	}
}