using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Slugma Specie to store common natural stats of every {'abilities': ['magma-armor', 'flame-body', 'weak-armor'], 'base_experience': 50, 'height': 7, 'id': 218, 'moves': ['body-slam', 'double-edge', 'ember', 'flamethrower', 'rock-throw', 'toxic', 'mimic', 'double-team', 'recover', 'harden', 'smokescreen', 'defense-curl', 'light-screen', 'reflect', 'self-destruct', 'smog', 'fire-blast', 'amnesia', 'acid-armor', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'stockpile', 'spit-up', 'swallow', 'heat-wave', 'will-o-wisp', 'memento', 'facade', 'nature-power', 'yawn', 'secret-power', 'overheat', 'rock-tomb', 'iron-defense', 'natural-gift', 'guard-swap', 'earth-power', 'lava-plume', 'captivate', 'flame-burst', 'flame-charge', 'after-you', 'round', 'clear-smog', 'incinerate', 'inferno', 'confide', 'infestation'], 'name': 'slugma', 'stats': {'hp': 40, 'attack': 40, 'defense': 40, 'special-attack': 70, 'special-defense': 40, 'speed': 20}, 'types': ['fire'], 'weight': 350, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'red', 'shape': 'squiggle', 'habitat': 'mountain', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'マグマッグ', 'roomaji': 'Magmag', 'ko': '마그마그', 'zh-Hant': '熔岩蟲', 'fr': 'Limagma', 'de': 'Schneckmag', 'es': 'Slugma', 'it': 'Slugma', 'en': 'Slugma', 'ja': 'マグマッグ', 'zh-Hans': '熔岩虫'}, 'genera': {'ja-Hrkt': 'ようがんポケモン', 'ko': '용암포켓몬', 'zh-Hant': '熔岩寶可夢', 'fr': 'Pokémon Lave', 'de': 'Lava', 'es': 'Pokémon Lava', 'it': 'Pokémon Lava', 'en': 'Lava Pokémon', 'ja': 'ようがんポケモン', 'zh-Hans': '熔岩宝可梦'}}
	public class SpecieSlugma : PokemonSpecie
	{
#nullable enable
		private static SpecieSlugma? _instance = null;
#nullable restore
        public static SpecieSlugma Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSlugma();
                }
                return _instance;
            }
        }

		public SpecieSlugma() : base(
			"Slugma",
			40, // HPs
			40, 40, // Attack & Defense
			70, 40, // Special Attack & Defense
			20			
		) {}
	}


	//Slugma Pokemon Class
	public class Slugma : Pokemon
	{

		public Slugma(string nickname, int level)
		: base(
				218,
				SpecieSlugma.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Slugma() : base(
			218,
			SpecieSlugma.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}