using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Vulpix Specie to store common natural stats of every {'abilities': ['flash-fire', 'drought'], 'base_experience': 60, 'height': 6, 'id': 37, 'moves': ['headbutt', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'roar', 'disable', 'ember', 'flamethrower', 'fire-spin', 'dig', 'toxic', 'hypnosis', 'quick-attack', 'rage', 'mimic', 'double-team', 'confuse-ray', 'reflect', 'bide', 'fire-blast', 'swift', 'skull-bash', 'rest', 'substitute', 'snore', 'curse', 'flail', 'spite', 'protect', 'feint-attack', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'iron-tail', 'hidden-power', 'sunny-day', 'psych-up', 'heat-wave', 'will-o-wisp', 'facade', 'role-play', 'imprison', 'grudge', 'secret-power', 'overheat', 'extrasensory', 'howl', 'covet', 'natural-gift', 'payback', 'power-swap', 'flare-blitz', 'dark-pulse', 'energy-ball', 'zen-headbutt', 'captivate', 'ominous-wind', 'flame-burst', 'flame-charge', 'foul-play', 'round', 'hex', 'incinerate', 'inferno', 'tail-slap', 'confide', 'baby-doll-eyes'], 'name': 'vulpix', 'stats': {'hp': 38, 'attack': 41, 'defense': 40, 'special-attack': 50, 'special-defense': 65, 'speed': 65}, 'types': ['fire'], 'weight': 99, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 6, 'capture_rate': 190, 'color': 'brown', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ロコン', 'roomaji': 'Rokon', 'ko': '식스테일', 'zh-Hant': '六尾', 'fr': 'Goupix', 'de': 'Vulpix', 'es': 'Vulpix', 'it': 'Vulpix', 'en': 'Vulpix', 'ja': 'ロコン', 'zh-Hans': '六尾'}, 'genera': {'ja-Hrkt': 'きつねポケモン', 'ko': '여우포켓몬', 'zh-Hant': '狐狸寶可夢', 'fr': 'Pokémon Renard', 'de': 'Fuchs', 'es': 'Pokémon Zorro', 'it': 'Pokémon Volpe', 'en': 'Fox Pokémon', 'ja': 'きつねポケモン', 'zh-Hans': '狐狸宝可梦'}}
	public class SpecieVulpix : PokemonSpecie
	{
#nullable enable
		private static SpecieVulpix? _instance = null;
#nullable restore
        public static SpecieVulpix Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVulpix();
                }
                return _instance;
            }
        }

		public SpecieVulpix() : base(
			"Vulpix",
			38, // HPs
			41, 40, // Attack & Defense
			50, 65, // Special Attack & Defense
			65			
		) {}
	}


	//Vulpix Pokemon Class
	public class Vulpix : Pokemon
	{

		public Vulpix(string nickname, int level) : base(
			37,
			SpecieVulpix.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance			
		) {}

		public Vulpix() : base(
			37,
			SpecieVulpix.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}