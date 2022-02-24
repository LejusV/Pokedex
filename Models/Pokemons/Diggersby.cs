using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Diggersby Specie to store common natural stats of every {'abilities': ['pickup', 'cheek-pouch', 'huge-power'], 'base_experience': 148, 'height': 10, 'id': 660, 'moves': ['double-slap', 'fire-punch', 'ice-punch', 'thunder-punch', 'swords-dance', 'cut', 'double-kick', 'tackle', 'take-down', 'leer', 'surf', 'hyper-beam', 'low-kick', 'strength', 'earthquake', 'dig', 'toxic', 'agility', 'quick-attack', 'double-team', 'rest', 'rock-slide', 'super-fang', 'substitute', 'thief', 'snore', 'flail', 'protect', 'sludge-bomb', 'mud-slap', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rock-smash', 'uproar', 'torment', 'facade', 'focus-punch', 'nature-power', 'superpower', 'recycle', 'brick-break', 'knock-off', 'endeavor', 'snatch', 'secret-power', 'odor-sleuth', 'rock-tomb', 'bulk-up', 'bounce', 'mud-shot', 'hammer-arm', 'u-turn', 'payback', 'fling', 'gastro-acid', 'last-resort', 'earth-power', 'giga-impact', 'gunk-shot', 'iron-head', 'stone-edge', 'grass-knot', 'smack-down', 'foul-play', 'round', 'bulldoze', 'work-up', 'wild-charge', 'rototiller', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'diggersby', 'stats': {'hp': 85, 'attack': 56, 'defense': 77, 'special-attack': 50, 'special-defense': 77, 'speed': 78}, 'types': ['normal', 'ground'], 'weight': 424, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 127, 'color': 'brown', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ホルード', 'ko': '파르토', 'zh-Hant': '掘地兔', 'fr': 'Excavarenne', 'de': 'Grebbit', 'es': 'Diggersby', 'it': 'Diggersby', 'en': 'Diggersby', 'ja': 'ホルード', 'zh-Hans': '掘地兔'}, 'genera': {'ja-Hrkt': 'あなほりポケモン', 'ko': '땅구멍파기포켓몬', 'zh-Hant': '挖洞寶可夢', 'fr': 'Pokémon Fouisseur', 'de': 'Baugräber', 'es': 'Pokémon Excavador', 'it': 'Pokémon Scavabuche', 'en': 'Digging Pokémon', 'ja': 'あなほりポケモン', 'zh-Hans': '挖洞宝可梦'}}
	public class SpecieDiggersby : PokemonSpecie
	{
#nullable enable
		private static SpecieDiggersby? _instance = null;
#nullable restore
        public static SpecieDiggersby Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDiggersby();
                }
                return _instance;
            }
        }

		public SpecieDiggersby() : base(
			"Diggersby",
			85, // HPs
			56, 77, // Attack & Defense
			50, 77, // Special Attack & Defense
			78			
		) {}
	}


	//Diggersby Pokemon Class
	public class Diggersby : Pokemon
	{

		public Diggersby(string nickname, int level)
		: base(
				660,
				SpecieDiggersby.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Diggersby(int level)
		: base(
				660,
				SpecieDiggersby.Instance, // Pokemon Specie
				"Diggersby", level,
				Normal.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Diggersby() : base(
			660,
			SpecieDiggersby.Instance, // Pokemon Specie
			Normal.Instance, Ground.Instance			
		) {}
	}
}