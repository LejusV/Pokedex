using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bunnelby Specie to store common natural stats of every {'abilities': ['pickup', 'cheek-pouch', 'huge-power'], 'base_experience': 47, 'height': 4, 'id': 659, 'moves': ['double-slap', 'cut', 'double-kick', 'tackle', 'take-down', 'leer', 'surf', 'strength', 'earthquake', 'dig', 'toxic', 'agility', 'quick-attack', 'double-team', 'defense-curl', 'rest', 'rock-slide', 'super-fang', 'substitute', 'thief', 'snore', 'flail', 'protect', 'sludge-bomb', 'mud-slap', 'spikes', 'sandstorm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rock-smash', 'torment', 'facade', 'nature-power', 'recycle', 'brick-break', 'endeavor', 'secret-power', 'odor-sleuth', 'rock-tomb', 'bulk-up', 'bounce', 'mud-shot', 'u-turn', 'payback', 'fling', 'last-resort', 'iron-head', 'stone-edge', 'grass-knot', 'smack-down', 'round', 'bulldoze', 'work-up', 'wild-charge', 'confide', 'power-up-punch'], 'name': 'bunnelby', 'stats': {'hp': 38, 'attack': 36, 'defense': 38, 'special-attack': 32, 'special-defense': 36, 'speed': 57}, 'types': ['normal'], 'weight': 50, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ホルビー', 'ko': '파르빗', 'zh-Hant': '掘掘兔', 'fr': 'Sapereau', 'de': 'Scoppel', 'es': 'Bunnelby', 'it': 'Bunnelby', 'en': 'Bunnelby', 'ja': 'ホルビー', 'zh-Hans': '掘掘兔'}, 'genera': {'ja-Hrkt': 'あなほりポケモン', 'ko': '땅구멍파기포켓몬', 'zh-Hant': '挖洞寶可夢', 'fr': 'Pokémon Fouisseur', 'de': 'Baugräber', 'es': 'Pokémon Excavador', 'it': 'Pokémon Scavabuche', 'en': 'Digging Pokémon', 'ja': 'あなほりポケモン', 'zh-Hans': '挖洞宝可梦'}}
	public class SpecieBunnelby : PokemonSpecie
	{
#nullable enable
		private static SpecieBunnelby? _instance = null;
#nullable restore
        public static SpecieBunnelby Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBunnelby();
                }
                return _instance;
            }
        }

		public SpecieBunnelby() : base(
			"Bunnelby",
			38, // HPs
			36, 38, // Attack & Defense
			32, 36, // Special Attack & Defense
			57			
		) {}
	}


	//Bunnelby Pokemon Class
	public class Bunnelby : Pokemon
	{

		public Bunnelby(string nickname, int level)
		: base(
				659,
				SpecieBunnelby.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bunnelby() : base(
			659,
			SpecieBunnelby.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}